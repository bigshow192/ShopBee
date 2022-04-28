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
    public partial class Form5 : Form
    {
        private Product p2 = new Product();
        private void Btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this.p2);
            f3.ShowDialog();
        }
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(String str)
        {
            InitializeComponent();
            this.label4.Text = "Kết quả tìm kiếm: " + str;
            int k = 100;
            for (int i=0;i<24;i++)
            {
                if (Program.p1[i].getName().Contains(str)==true)
                {
                    PictureBox picture = new PictureBox
                    {
                        Name = Program.p1[i].getName(),
                        Size = new Size(200, 200),
                        Location = new Point(k, 130),
                        Image = Image.FromFile(Program.p1[i].getImage()),
                        SizeMode= PictureBoxSizeMode.StretchImage,
                        
                    };
                    Label label1 = new Label
                    {
                       
                    };
                    label1.AutoSize = true;
                    label1.BackColor = System.Drawing.Color.Transparent;
                    label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    label1.Location = new System.Drawing.Point(k+50, 377);
                    label1.Name = Program.p1[i].getName();
                    label1.Size = new System.Drawing.Size(63, 24);
                    label1.TabIndex = 18;
                    label1.Text = Program.p1[i].getName();
                    k = k + 300;
                    this.p2 = Program.p1[i];
                    picture.Click += Btn_Click;
                    this.Controls.Add(picture);
                    this.Controls.Add(label1);

                }
            }
        }
    }
}
