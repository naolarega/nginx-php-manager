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
        public delegate void ProcessManagementEventHandler(string message);
        public delegate void ProcessManagementExitEventHandler(int code);
        public static event ProcessManagementEventHandler nginxDataRecieved;
        public static event ProcessManagementEventHandler phpDataRecieved;
        public static event ProcessManagementEventHandler nginxErrorRecieved;
        public static event ProcessManagementEventHandler phpErrorRecieved;
        public static event ProcessManagementExitEventHandler phpExited;
        public static event ProcessManagementExitEventHandler nginxExited;

        public static void startNginxProcess()
        {
            if (
                !isProcessAlreadyRunning("nginx") &&
                isPathValid(
                    Config.config.nginx.directory,
                    "nginx.exe"
                ))
            {
                Process nginxProcess = new Process();

                nginxProcess.StartInfo.FileName = string.Format("{0}\\nginx.exe", Config.config.nginx.directory.Trim('\\'));
                nginxProcess.StartInfo.WorkingDirectory = Config.config.nginx.directory;
                nginxProcess.StartInfo.RedirectStandardOutput = true;
                nginxProcess.StartInfo.RedirectStandardError = true;
                nginxProcess.EnableRaisingEvents = true;

                nginxProcess.OutputDataReceived += (sender, e) => { nginxDataRecieved(e.ToString()); };
                nginxProcess.ErrorDataReceived += (sender, e) => { nginxErrorRecieved(e.ToString()); };
                nginxProcess.Exited += (sender, e) => { nginxExited(1); };

                try
                {
                    nginxProcess.Start();
                }
                catch
                {
                    return;
                }
            }
        }

        public static void startPhpProcess()
        {
            if(
                !isProcessAlreadyRunning("CGI / FastCGI") &&
                isPathValid(
                    Config.config.php.directory,
                    "php-cgi.exe"
                ))
            {
                Process phpProcess = new Process();

                phpProcess.StartInfo.FileName = string.Format("{0}\\php-cgi.exe", Config.config.php.directory.Trim('\\'));
                phpProcess.StartInfo.WorkingDirectory = Config.config.php.directory;
                phpProcess.StartInfo.Arguments = string.Format(
                    "-b {0}:{1}",
                    Config.config.php.address,
                    Config.config.php.port
                    );
                phpProcess.StartInfo.RedirectStandardOutput = true;
                phpProcess.StartInfo.RedirectStandardError = true;
                phpProcess.EnableRaisingEvents = true;

                phpProcess.OutputDataReceived += (sender, e) => { phpDataRecieved(e.ToString()); };
                phpProcess.ErrorDataReceived += (sender, e) => { phpErrorRecieved(e.ToString()); };
                phpProcess.Exited += (sender, e) => { phpExited(1); };

                try
                {
                    phpProcess.Start();
                }
                catch
                {
                    return;
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

        public static bool isPathValid(string path, string executable)
        {
            return Directory.Exists(path) && File.Exists(
                string.Format("{0}\\{1}", path.Trim('\\'), executable)
                );
        }
    }
}
