using System;
using System.IO;
using System.Xml;
using nginx_php_manager.model;

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
        public static ConfigModel config;
        public static ConfigStatus status = ConfigStatus.NO_CONFIG;

        private Config() { }

        public static void read()
        {
            if (File.Exists(configFileName))
            {
                configDocumment = new XmlDocument();
                try
                {
                    configDocumment.Load(
                        string.Format("{0}\\{1}.xml", Directory.GetCurrentDirectory(), configFileName)
                        );
                    deserialize();
                    status = ConfigStatus.SUCCESS;

                }
                catch
                {
                    status = ConfigStatus.FAILED;
                }
            }
            else
            {
                status = ConfigStatus.NO_CONFIG;
            }
        }

        private static void deserialize()
        {
            if(configDocumment.DocumentElement.Name == "config")
            {
                config = new ConfigModel();
                foreach(XmlNode node in configDocumment.DocumentElement.ChildNodes)
                {
                    switch(node.Name)
                    {
                        case "nginx":
                            loadNginxConfig(node.ChildNodes);
                            break;
                        case "php":
                            loadPhpConfig(node.ChildNodes);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static void loadNginxConfig(XmlNodeList nginxNode)
        {
            foreach(XmlNode node in nginxNode)
            {
                if(node.Name == "directory")
                {
                }
                switch (node.Name)
                {
                    case "directory":
                        config.nginx.directory = node.Attributes["value"] != null ?
                            node.Attributes["value"].Value :
                            string.Empty;
                        break;
                    case "configDirectory":
                        config.nginx.configDirectory = node.Attributes["value"] != null ?
                            node.Attributes["value"].Value :
                            string.Empty;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void loadPhpConfig(XmlNodeList nginxNode)
        {
            foreach(XmlNode node in nginxNode)
            {
                if(node.Name == "directory")
                {
                }
                switch (node.Name)
                {
                    case "directory":
                        config.php.directory = node.Attributes["value"] != null ?
                            node.Attributes["value"].Value :
                            string.Empty;
                        break;
                    case "configDirectory":
                        config.php.configDirectory = node.Attributes["value"] != null ?
                            node.Attributes["value"].Value :
                            string.Empty;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
