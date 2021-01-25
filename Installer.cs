namespace CSharpTutorial
{
    public class Installer
    {
        private Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public Installer()
        {
            //this.logger = logger;
        }
        public void Install()
        {
            _logger.Log("Install completed");
        }



    }

}
