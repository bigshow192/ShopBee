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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        private Product p;
        public Form3(Product p)
        {
            InitializeComponent();
            this.p = p;
            this.label2.Text = Program.sodu.ToString();
            this.label6.Text = p.getName();
            this.label5.Text = p.getprice().ToString();
            this.pictureBox2.Image = Image.FromFile(p.getImage());
            this.label9.Text= p.getprice().ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int x = Int32.Parse(this.label9.Text);
            int k= Convert.ToInt32(this.numericUpDown1.Value);
            x = k * p.getprice();
            this.label9.Text = x.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Program.sodu; ;
            int h= Int32.Parse(this.label9.Text);
            if (k >= h)
            {
                String s = (k - h).ToString();
                DialogResult dialogResult = MessageBox.Show("Số dư của bạn sau khi thanh toán là:" + s + ". Bạn có chắc muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.sodu = Program.sodu - h;
                    this.label2.Text = Program.sodu.ToString();
                    ListViewItem item = new ListViewItem();
                    item.Text = this.p.getName();
                    ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (this.numericUpDown1.Value.ToString()));
                    item.SubItems.Add(subitem);
                    ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, (h.ToString()));
                    item.SubItems.Add(subitem2);
                    Program.arritem[Program.lengthitem] = item;
                    Program.lengthitem++;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            else
            {
                MessageBox.Show("Số dư của bạn không đủ để thanh toán.", "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
                    
            
        }
    }
}
