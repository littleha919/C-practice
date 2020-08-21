using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ariel_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Say hello = new Say();
            hello.name = txtName.Text;
            hello.english = txtEgName.Text;
            hello.gender = txtGender.Text;
            hello.constell = txtConst.Text;

            MessageBox.Show("Hello" + hello.greet());
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            Say hi = new Say();
            hi.name = txtName.Text;
            hi.english = txtEgName.Text;
            hi.gender = txtGender.Text;
            hi.constell = txtConst.Text;

            MessageBox.Show("Hi" + hi.greet());
        }
    }
}
