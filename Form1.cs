using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Product[] p;
        public Form1(Product []p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ttnam_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(7);
            f2.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(5);
            f2.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(3);
            f2.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(1);
            f2.ShowDialog();
        }

        private void p5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(2);
            f2.ShowDialog();
        }

        private void p6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(4);
            f2.ShowDialog();
        }

        private void p7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(6);
            f2.ShowDialog();
        }

        private void p8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(8);
            f2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String str = this.textBox1.Text;
            Form5 f5 = new Form5(str);
            f5.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
