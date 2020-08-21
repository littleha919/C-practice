using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8_MyClac
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            clsClac p = new clsClac(); 
            p.N1 = double.Parse(txtN1.Text);
            p.N2 = double.Parse(txtN2.Text);
            txtAns.Text = p.Plus().ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            clsClac m = new clsClac();
            m.N1 = double.Parse(txtN1.Text);
            m.N2 = double.Parse(txtN2.Text);
            txtAns.Text = m.Min().ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            clsClac t = new clsClac();
            t.N1 = double.Parse(txtN1.Text);
            t.N2 = double.Parse(txtN2.Text);
            txtAns.Text = t.Tim().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            clsClac d = new clsClac();
            d.N1 = double.Parse(txtN1.Text);
            d.N2 = double.Parse(txtN2.Text);
            txtAns.Text = d.Div().ToString();
        }
    }
}
