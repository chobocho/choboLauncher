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
            buttonTable["button10"] = button18;
            buttonTable["button11"] = button17;
            buttonTable["button12"] = button16;
            buttonTable["button13"] = button15;
            buttonTable["button14"] = button14;
            buttonTable["button15"] = button13;
            buttonTable["button16"] = button12;
            buttonTable["button17"] = button11;
            buttonTable["button18"] = button10;
            buttonTable["button19"] = button19;
            buttonTable["button20"] = button27;
            buttonTable["button21"] = button26;
            buttonTable["button22"] = button25;
            buttonTable["button23"] = button24;
            buttonTable["button24"] = button23;
            buttonTable["button25"] = button22;
            buttonTable["button26"] = button21;
            buttonTable["button27"] = button20;
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
            ChoboUtil.openUrl(_buttonInfos["button1"].target);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button2"].target);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button3"].target);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button4"].target);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button5"].target);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button6"].target);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button7"].target);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button8"].target);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button9"].target);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button10"].target);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button11"].target);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button12"].target);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button13"].target);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button14"].target);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button15"].target);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button16"].target);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button17"].target);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button18"].target);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button19"].target);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button20"].target);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button21"].target);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button22"].target);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button23"].target);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button24"].target);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button25"].target);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button26"].target);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            ChoboUtil.openUrl(_buttonInfos["button27"].target);
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