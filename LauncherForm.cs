using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;

namespace ChoboLauncher
{
    public partial class LauncherForm : Form
    {
        private readonly ChoboUtil _choboUtil;
        private readonly Dictionary<string, Button> buttonTable = new Dictionary<string, Button>();
        private Dictionary<string, ButtonInfo> _buttonInfos;

        public LauncherForm(Dictionary<string, ButtonInfo> buttonInfos)
        {
            _buttonInfos = buttonInfos;
            InitializeComponent();
            _choboUtil = new ChoboUtil();
            InitButtonTable();
            UpdateDefaultButton(_buttonInfos);
        }

        private void UpdateDefaultButton(Dictionary<string, ButtonInfo> buttonInfos)
        {
            foreach (var btn in buttonInfos)
            {
                buttonTable[btn.Key].Text = btn.Value.name;
            }
        }

        private void InitButtonTable()
        {
            buttonTable["button1"] = button1;
            buttonTable["button2"] = button2;
            buttonTable["button3"] = button3;
            buttonTable["button4"] = button4;
            buttonTable["button5"] = button5;
            buttonTable["button6"] = button6;
            buttonTable["button7"] = button7;
            buttonTable["button8"] = button8;
            buttonTable["button9"] = button9;
            buttonTable["button10"] = button10;
            buttonTable["button11"] = button11;
            buttonTable["button12"] = button12;
            buttonTable["button13"] = button13;
            buttonTable["button14"] = button14;
            buttonTable["button15"] = button15;
            buttonTable["button16"] = button16;
            buttonTable["button17"] = button17;
            buttonTable["button18"] = button18;
            buttonTable["button19"] = button19;
            buttonTable["button20"] = button20;
            buttonTable["button21"] = button21;
            buttonTable["button22"] = button22;
            buttonTable["button23"] = button23;
            buttonTable["button24"] = button24;
            buttonTable["button25"] = button25;
            buttonTable["button26"] = button26;
            buttonTable["button27"] = button27;
        }

        public ChoboUtil ChoboUtil
        {
            get { return _choboUtil; }
        }

        private void chobocho_com_Click(object sender, EventArgs e)
        {
            string linkUrl = "http://chobocho.com/";
            ChoboUtil.openUrl(linkUrl);
        }

        private void Tetris_Click(object sender, EventArgs e)
        {
            string linkUrl = "http://chobocho.com/game/tetris/index.html";
            ChoboUtil.openUrl(linkUrl);
        }

        private void FloppyBird_Click(object sender, EventArgs e)
        {
            string linkUrl = "http://www.chobocho.com/game/floppybird2/index.html";
            ChoboUtil.openUrl(linkUrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btnName = "button1";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string btnName = "button2";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string btnName = "button3";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string btnName = "button4";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string btnName = "button5";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string btnName = "button6";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string btnName = "button7";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string btnName = "button8";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string btnName = "button9";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string btnName = "button10";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            string btnName = "button11";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string btnName = "button12";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string btnName = "button13";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string btnName = "button14";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string btnName = "button15";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string btnName = "button16";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string btnName = "button17";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string btnName = "button18";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string btnName = "button19";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string btnName = "button20";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string btnName = "button21";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string btnName = "button22";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string btnName = "button23";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string btnName = "button24";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string btnName = "button25";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string btnName = "button26";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string btnName = "button27";
            if (_buttonInfos[btnName].name == ".") return;
            ChoboUtil.openUrl(_buttonInfos[btnName].target);
        }
    }

    public class ChoboUtil
    {
        public ChoboUtil()
        {
        }

        public void openUrl(string linkUrl)
        {
            try
            {
                Process.Start(new ProcessStartInfo() { FileName = linkUrl, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Problem during open URL: '{linkUrl}'");
            }
        }
    }
}