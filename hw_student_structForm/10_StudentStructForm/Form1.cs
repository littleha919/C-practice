using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_StudentStructForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string result;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student s;
            s.Name = txtName.Text;
            s.Ch = int.Parse(txtCh.Text);
            s.Eg = int.Parse(txtEg.Text);
            s.Ma = int.Parse(txtMa.Text);

            result = "姓名：" + s.Name + "\n國文：" + s.Ch + "分" +"\n英文：" + s.Eg + "分" + "\n數學：" + s.Ma + "分";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labShow.Text = result;
        }

        private void btnHighLow_Click(object sender, EventArgs e)
        {
            A[] high = new A[3];

            high[0] = new A("國文", int.Parse(txtCh.Text));
            high[1] = new A("英文", int.Parse(txtEg.Text));
            high[2] = new A("數學", int.Parse(txtMa.Text));

            var sorted = high.OrderBy((A s) => s.score).ToArray();

            labHighLow.Text = "最高科目成績為：" + sorted[2].key + sorted[2].score + "分" + 
                              "\n最低科目成績為：" + sorted[0].key + sorted[0].score + "分";
        }
    }
 }

