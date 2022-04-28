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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            for (int i = 0; i < Program.lengthitem; i++)
            {
                this.listView1.Items.Add(Program.arritem[i]);
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
