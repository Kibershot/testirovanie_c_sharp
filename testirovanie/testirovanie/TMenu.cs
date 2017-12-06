using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testirovanie
{
    public partial class TMenu : Form
    {
        public TMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Testing Testing = new Testing();
            this.Close();
            Testing.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Close();
            Form1.Show();
        }
    }
}
