using System;
using System.IO;
using System.Diagnostics;

namespace nginx_php_manager.lib
{
    public class ProcessManagement
    {
        public enum ProcessStatus
        {
            RUNNING,
            STOPPED,
            PAUSED
        };
        public static ProcessStatus nginxStatus { get; set; }
        public static ProcessStatus phpStatus { get; set; }
        public static string nginxProcessName = "nginx";
        public static string phpProcessName = "php-cgi";
        public static string nginxExecutable = "nginx.exe";
        public static string phpExecutable = "php-cgi.exe";
        public delegate void ProcessManagementEventHandler(string message);
        public delegate void ProcessManagementExitEventHandler(int code);
        public static event ProcessManagementEventHandler nginxDataRecieved;
        public static event ProcessManagementEventHandler phpDataRecieved;
        public static event ProcessManagementEventHandler nginxErrorRecieved;
        public static event ProcessManagementEventHandler phpErrorRecieved;
        public static event ProcessManagementExitEventHandler phpExited;
        public static event ProcessManagementExitEventHandler nginxExited;

        public static bool startNginxProcess()
        {
            if (
                !isProcessAlreadyRunning(nginxProcessName) &&
                isPathValid(
                    Config.config.nginx.directory,
                    nginxExecutable
                ))
            {
                Process nginxProcess = new Process();

                nginxProcess.StartInfo.FileName = string.Format(
                    "{0}\\{1}",
                    Config.config.nginx.directory.Trim('\\'),
                    nginxExecutable
                    ); ;
                nginxProcess.StartInfo.WorkingDirectory = Config.config.nginx.directory;
                nginxProcess.StartInfo.CreateNoWindow = true;
                nginxProcess.StartInfo.RedirectStandardOutput = true;
                nginxProcess.StartInfo.RedirectStandardError = true;

                nginxProcess.OutputDataReceived += (sender, e) => nginxDataRecieved(e.ToString());
                nginxProcess.ErrorDataReceived += (sender, e) => nginxErrorRecieved(e.ToString());

                try
                {
                    nginxProcess.Start();
                    return true;
                }
                catch(Exception e)
                {
                    nginxErrorRecieved(e.Message);
                    return false;
                }
            }
            return false;
        }

        public static bool startPhpProcess()
        {
            bool notRunning = !isProcessAlreadyRunning(phpProcessName);
            bool pathValid = isPathValid(
                    Config.config.php.directory,
                    phpExecutable
                );

            if (notRunning && pathValid)
            {
                Process phpProcess = new Process();

                phpProcess.StartInfo.FileName = string.Format(
                    "{0}\\{1}",
                     Config.config.php.directory.Trim('\\'),
                     phpExecutable
                     );
                phpProcess.StartInfo.WorkingDirectory = Config.config.php.directory;
                phpProcess.StartInfo.CreateNoWindow = true;
                phpProcess.StartInfo.Arguments = string.Format(
                    "-b {0}:{1}",
                    Config.config.php.address,
                    Config.config.php.port
                    );
                phpProcess.StartInfo.RedirectStandardOutput = true;
                phpProcess.StartInfo.RedirectStandardError = true;

                phpProcess.OutputDataReceived += (sender, e) => phpDataRecieved(e.ToString());
                phpProcess.ErrorDataReceived += (sender, e) => phpErrorRecieved(e.ToString());

                try
                {
                    phpProcess.Start();
                    return true;
                }
                catch(Exception e)
                {
                    phpErrorRecieved(e.Message);
                    return false;
                }
            }

            if (!notRunning)
            {
                return true;
            }
            else if (!pathValid)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public static void stopNginxProcess()
        {
            bool alreadRunning = isProcessAlreadyRunning(nginxProcessName);
            if (alreadRunning)
            {
                Process nginxStopProcess = new Process();

                nginxStopProcess.StartInfo.FileName = string.Format(
                    "{0}\\{1}",
                     Config.config.nginx.directory.Trim('\\'),
                     nginxExecutable
                     );
                nginxStopProcess.StartInfo.WorkingDirectory = Config.config.nginx.directory;
                nginxStopProcess.StartInfo.CreateNoWindow = true;
                nginxStopProcess.StartInfo.Arguments = "-s stop";

                nginxStopProcess.EnableRaisingEvents = true;

                nginxStopProcess.Exited += (sender, e) => nginxExited(1);

                try
                {
                    nginxStopProcess.Start();
                }
                catch(Exception e)
                {
                    nginxErrorRecieved(e.Message);
                }
            }
        }

        public static void stopPhpProcess()
        {
            bool alreadyRunning = isProcessAlreadyRunning(phpProcessName);
            if (alreadyRunning)
            {
                Process[] phpProcesses = Process.GetProcessesByName(phpProcessName);
                int totalPhpProcesses = phpProcesses.Length;
                int killedPhpProcessed = 0;
                foreach (Process process in phpProcesses)
                {
                    try
                    {
                        process.Kill(true);
                        killedPhpProcessed++;
                    }
                    catch { }
                }
                
                if(killedPhpProcessed == totalPhpProcesses)
                {
                    phpExited(1);
                }
            }
        }

        public static bool isProcessAlreadyRunning(string processName)
        {
            return Array.Exists<Process>(
                Process.GetProcesses(),
                process => process.ProcessName == processName
                );
        }

        public static void writeProcesses()
        {
            StreamWriter processFile = new StreamWriter(
                string.Format(
                    "{0}\\processes.txt",
                    Directory.GetCurrentDirectory()
                )
                );

            string processesData = string.Empty;

            processesData += "Process name - pid - title";
            foreach(Process process in Process.GetProcesses())
            {
                processesData += string.Format(
                    "{0} - {1} - {2}\n",
                    process.ProcessName,
                    process.Id,
                    process.MainWindowTitle
                    );
            }

            processFile.Write(processesData);
            processFile.Flush();
            processFile.Close();
        }

        public static bool isPathValid(string path, string executable)
        {
            return Directory.Exists(path) && File.Exists(
                string.Format("{0}\\{1}", path.Trim('\\'), executable)
                );
        }
    }
}
