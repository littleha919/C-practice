using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CatGif cat;
            cat = new CatGif();
            cat.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            momo dog;
            dog = new momo();
            dog.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cat Nana;
            Nana = new cat();
            Nana.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SunLi she;
            she = new SunLi();
            she.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            mountain moun;
            moun = new mountain();
            moun.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            HOCCjpg HOCC;
            HOCC = new HOCCjpg();
            HOCC.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            aurora sky;
            sky = new aurora();
            sky.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            sailormoon moon;
            moon = new sailormoon();
            moon.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mermaid ariel;
            ariel = new Mermaid();
            ariel.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            HongKong ariel;
            ariel = new HongKong();
            ariel.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            bridget bj;
            bj = new bridget();
            bj.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            wedding marry;
            marry = new wedding();
            marry.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Pocahontas wind;
            wind = new Pocahontas();
            wind.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            BlueMagpie bird;
            bird = new BlueMagpie();
            bird.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            blackBear bear;
            bear = new blackBear();
            bear.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            StoneTiger LeopardCat;
            LeopardCat = new StoneTiger();
            LeopardCat.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            TAIWAN Formosa;
            Formosa = new TAIWAN();
            Formosa.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            equal sameSexMarriage;
            sameSexMarriage = new equal();
            sameSexMarriage.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            DearFriend HOCC1;
            HOCC1 = new DearFriend();
            HOCC1.Show();
        }
    }
}

