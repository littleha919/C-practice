using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ariel_Loan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double loanNum;
        public double periodNum;
        public double rateNum;
        public double downNum;

        private void btnTotal_Click(object sender, EventArgs e)
        {
            loanNum = double.Parse(txtHouse.Text);
            periodNum = double.Parse(txtPeriod.Text) * 12;
            rateNum = double.Parse(txtRate.Text) * 0.01 / 12;
            downNum = double.Parse(txtDownPay.Text);

            double monthRate = (Math.Pow((1 + rateNum), periodNum) * rateNum) / (Math.Pow((1 + rateNum), periodNum) - 1);
            double totalPay = (loanNum - downNum) * monthRate * periodNum + downNum;
            int totalPayInt;
            totalPayInt = (int)totalPay;

            MessageBox.Show("總付款：" + totalPayInt + "元");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            loanNum = double.Parse(txtHouse.Text);
            periodNum = double.Parse(txtPeriod.Text) * 12;
            rateNum = double.Parse(txtRate.Text) * 0.01 / 12;
            downNum = double.Parse(txtDownPay.Text);

            double monthRate = (Math.Pow((1 + rateNum),periodNum)*rateNum)/ (Math.Pow((1 + rateNum), periodNum)-1);
            double monthPay = loanNum * monthRate;
            int monthPayInt;
            monthPayInt = (int)monthPay;

            MessageBox.Show("月付額：" + monthPayInt + "元");
        }

        public void GetValue(string value1, TextBox value2)
        {
            txtHouse.Text = value1;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int LoanReport = int.Parse(txtHouse.Text) - int.Parse(txtDownPay.Text);
            string LoanReportStr = LoanReport.ToString();

            double monthPay = loanNum * (Math.Pow((1 + rateNum), periodNum) * rateNum) / (Math.Pow((1 + rateNum), periodNum) - 1);
            int monthPayInt = (int)monthPay;
            string monthPayStr = monthPayInt.ToString();

            double monthRate = (Math.Pow((1 + rateNum), periodNum) * rateNum) / (Math.Pow((1 + rateNum), periodNum) - 1);
            double totalPay = (loanNum - downNum) * monthRate * periodNum + downNum;
            int totalPayInt;
            totalPayInt = (int)totalPay;
            string totalPayStr = totalPayInt.ToString();

            Form2 f = new Form2(LoanReportStr, txtPeriod.Text,txtRate.Text, monthPayStr, totalPayStr);

            f.Show(this);
        }
    }
}
