using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_POS
{
    public partial class POS : Form
    {
        int Total = 0;
        string List = "";
        string ShrimpList = "";
        string PorkList = "";
        string CrabList = "";
        string BeefList = "";
        int ShrimpTotal = 0;
        int ShrimpPrice = 0;
        int PorkTotal = 0;
        int PorkPrice = 0;
        int CrabTotal = 0;
        int CrabPrice = 0;
        int BeefTotal = 0;
        int BeefPrice = 0;

        public POS()
        {
            InitializeComponent();
        }

        private void btnShrimp_Click(object sender, EventArgs e)
        {
            Total = Total + 400;
            labPrice.Text = "NT$ " + Total;
            ShrimpPrice = ShrimpPrice + 400;
            ShrimpTotal = ShrimpTotal + 1;
            ShrimpList = "泰國蝦 x " + ShrimpTotal + ",共NT$" + ShrimpPrice + Environment.NewLine;
            labList.Text = List + ShrimpList + PorkList + CrabList + BeefList;
        }

        private void btnPork_Click(object sender, EventArgs e)
        {
            Total = Total + 500;
            labPrice.Text = "NT$ " + Total;
            PorkPrice = PorkPrice + 500;
            PorkTotal = PorkTotal + 1;
            PorkList = "松阪豬 x " + PorkTotal + ",共NT$" + PorkPrice + Environment.NewLine;
            labList.Text = List + ShrimpList + PorkList + CrabList + BeefList;
        }

        private void btnCrab_Click(object sender, EventArgs e)
        {
            Total = Total + 1300;
            labPrice.Text = "NT$ " + Total;
            CrabPrice = CrabPrice + 1300;
            CrabTotal = CrabTotal + 1;
            CrabList = "松葉蟹 x " + CrabTotal + ",共NT$" + CrabPrice + Environment.NewLine;
            labList.Text = List + ShrimpList + PorkList + CrabList + BeefList;
        }

        private void btnBeef_Click(object sender, EventArgs e)
        {
            Total = Total + 3200;
            labPrice.Text = "NT$ " + Total;
            BeefPrice = BeefPrice + 3200;
            BeefTotal = BeefTotal + 1;
            BeefList = "神戶牛 x " + BeefTotal + ",共NT$" + BeefPrice + Environment.NewLine;
            labList.Text = List + ShrimpList + PorkList + CrabList + BeefList;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show
            ("總金額為：NT$" + Total, "確認付款"
            , MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show
            ("總金額為：NT$" + Total + Environment.NewLine + "折扣後金額為：NT$" + (Total * 0.9), "確認付款"
            , MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Total = 0;
            List = "";
            ShrimpList = "";
            PorkList = "";
            CrabList = "";
            BeefList = "";
            ShrimpTotal = 0;
            ShrimpPrice = 0;
            PorkTotal = 0;
            PorkPrice = 0;
            CrabTotal = 0;
            CrabPrice = 0;
            BeefTotal = 0;
            BeefPrice = 0;
            labList.Text = "尚未點餐";
            labPrice.Text = "NT$ " + Total;
        }
    }
}
