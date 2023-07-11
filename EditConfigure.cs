using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoboLauncher
{
    public partial class EditConfigure : Form
    {
        private readonly Dictionary<string, ButtonInfo> _btnInfos;

        public EditConfigure(Dictionary<string, ButtonInfo> btnInfos)
        {
            _btnInfos = btnInfos;
            InitializeComponent();
        }

        private void clearBtnName_Click(object sender, EventArgs e)
        {

        }

        private void clearBtnTarget_Click(object sender, EventArgs e)
        {

        }


        private void btnList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
