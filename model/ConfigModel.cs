namespace nginx_php_manager.model
{
    public class ConfigModel
    {
        public NginxModel nginx { get; set; }
        public PhpModel php { get; set; }
        public GeneralModel general { get; set; }
    }
}