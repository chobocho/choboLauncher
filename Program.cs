namespace ChoboLauncher
{
    public class ButtonInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string target { get; set; }
    }
    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            const string cfgFileName = "ChoboLauncher_cfg.json";
            ApplicationConfiguration.Initialize();
            Application.Run(new LauncherForm(ChoboUtil.LoadConfig(cfgFileName)));
        }
    }
}