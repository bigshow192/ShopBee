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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Product[] a = new Product[24];
        public Form2(int category)
        {
            
            InitializeComponent();
            int length = 23;
           
            int k = 0;
            for (int i=0;i<=length;i++)
            {
                if (Program.p1[i].getCategory()==category)
                {
                    a[k] = Program.p1[i];
                    k++;
                }
            }
            this.label1.Text = a[0].getName();
            this.label2.Text = a[1].getName();
            this.label3.Text = a[2].getName();
            this.label4.Text = a[0].theloai();
            this.pictureBox2.Image = Image.FromFile(a[0].getImage());
            this.pictureBox4.Image = Image.FromFile(a[1].getImage());
            this.pictureBox5.Image = Image.FromFile(a[2].getImage());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(a[0]);
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(a[1]);
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(a[2]);
            f3.ShowDialog();
        }
    }
}
