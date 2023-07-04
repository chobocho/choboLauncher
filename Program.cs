using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            Dictionary<string, ButtonInfo> buttonInfos = new Dictionary<string, ButtonInfo>();
            string config = "";
            if (File.Exists(cfgFileName))
            {
                config = File.ReadAllText(cfgFileName);
                try
                {
                    JObject jObject = JObject.Parse(config);
                    foreach (JToken button in jObject["buttons"])
                    {
                        ButtonInfo buttonInfo = new ButtonInfo();
                        buttonInfo.id = button["id"].ToString();
                        buttonInfo.name = button["name"].ToString();
                        buttonInfo.target = button["target"].ToString();
                        buttonInfos[button["id"].ToString()] = buttonInfo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Chobocho's Launcher!");
                }
            }
            else
            {
                MessageBox.Show("There is no config file!", "Chobocho's Launcher!");
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new LauncherForm(buttonInfos));
        }
    }
}