using System;
using System.Windows.Forms;

namespace HTTPWebRequestCS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnKirim_Click(object sender, EventArgs e)
        {
            WebRequestHelper requestHelper = new WebRequestHelper(
                TxtUrl.Text.Trim(),
                CmbMethod.Text,
                TxtData.Text.Trim()
                );

            TxtResponse.Text = requestHelper.GetResponse();
        }
    }
}