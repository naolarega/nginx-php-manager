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
        public static ConfigModel config;
        public static ConfigStatus status = ConfigStatus.NO_CONFIG;
        public static string configPath = string.Empty;
        public static bool modified = false;

        private Config() { }

        public static void read()
        {
            configPath = string.Format("{0}\\{1}.xml", Directory.GetCurrentDirectory(), configFileName);
            if (File.Exists(configPath))
            {
                XmlDocument configDocument = new XmlDocument();
                try
                {
                    configDocument.Load(
                        configPath
                        );
                    deserialize(ref configDocument);
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

        public static void save()
        {
            if(config != null)
            {
                XmlDocument configDocument = new XmlDocument();
                XmlElement configRoot = configDocument.CreateElement("config");

                generateNginxDocument(ref configDocument, ref configRoot);
                generatePhpDocument(ref configDocument, ref configRoot);
                
                configDocument.AppendChild(configRoot);
                configDocument.Save(
                    configPath
                    );
            }
        }

        private static void generateNginxDocument(ref XmlDocument configDocument, ref XmlElement configRoot)
        {
            if (config.nginx != null)
            {
                XmlElement nginxConfig = configDocument.CreateElement("nginx");
                XmlElement nginxDirectory = configDocument.CreateElement("directory");
                XmlElement nginxConfigFile = configDocument.CreateElement("configFile");

                nginxDirectory.SetAttribute(
                    "value",
                    config.nginx.directory
                    );

                nginxConfigFile.SetAttribute(
                    "value",
                    config.nginx.configFile
                    );

                nginxConfig.AppendChild(nginxDirectory);
                nginxConfig.AppendChild(nginxConfigFile);

                configRoot.AppendChild(nginxConfig);
            }
        }

        private static void generatePhpDocument(ref XmlDocument configDocument, ref XmlElement configRoot)
        {
            if (config.nginx != null)
            {
                XmlElement phpConfig = configDocument.CreateElement("php");
                XmlElement phpDirectory = configDocument.CreateElement("directory");
                XmlElement phpBindPath = configDocument.CreateElement("bindPath");

                phpDirectory.SetAttribute(
                    "value",
                    config.php.directory
                    );

                phpBindPath.SetAttribute(
                    "address",
                    config.php.address
                    );

                phpBindPath.SetAttribute(
                    "port",
                    config.php.port.ToString()
                    );

                phpConfig.AppendChild(phpDirectory);
                phpConfig.AppendChild(phpBindPath);

                configRoot.AppendChild(phpConfig);
            }
        }

        public static void init()
        {
            if(config == null)
            {
                config = new ConfigModel();
                config.nginx = new NginxModel();
                config.php = new PhpModel();
            }
            else
            {
                if(config.nginx == null)
                {
                    config.nginx = new NginxModel();
                    config.php = new PhpModel();
                }
            }
        }

        private static void deserialize(ref XmlDocument configDocument)
        {
            if(configDocument.DocumentElement.Name == "config")
            {
                init();
                foreach(XmlNode node in configDocument.DocumentElement.ChildNodes)
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
                switch (node.Name)
                {
                    case "directory":
                        config.nginx.directory = node.Attributes["value"] != null ?
                            node.Attributes["value"].Value :
                            string.Empty;
                        break;
                    case "configFile":
                        config.nginx.configFile = node.Attributes["value"] != null ?
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
                switch (node.Name)
                {
                    case "directory":
                        config.php.directory = node.Attributes["value"] != null ?
                            node.Attributes["value"].Value :
                            string.Empty;
                        break;
                    case "bindPath":
                        decimal port = 0xd;

                        config.php.address = node.Attributes["address"] != null ?
                            node.Attributes["address"].Value :
                            string.Empty;

                        if(node.Attributes["port"] != null)
                        {
                            decimal.TryParse(node.Attributes["port"].Value, out port);
                            config.php.port = port;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
