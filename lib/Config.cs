using System;
using System.IO;
using System.Xml;

namespace nginx_php_manager.lib
{
    public class Config
    {
        public enum ConfigStatus
        {
            SUCCESS,
            FAILED,
            NO_CONFIG
        };
        private static string configFileName = "config";
        private static XmlDocument configDocumment;

        private Config() { }

        public static ConfigStatus read()
        {
            if (File.Exists(configFileName))
            {
                configDocumment = new XmlDocument();
                try
                {
                    configDocumment.Load(
                        string.Format("{0}\\{1}.xml", Directory.GetCurrentDirectory(), configFileName)
                        );
                    return ConfigStatus.SUCCESS;

                }
                catch
                {
                    return ConfigStatus.FAILED;
                }
            }
            else
            {
                return ConfigStatus.NO_CONFIG;
            }
        }
    }
}
