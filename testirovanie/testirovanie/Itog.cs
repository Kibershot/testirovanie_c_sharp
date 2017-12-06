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
    public partial class Itog : Form
    {
        public int good = 0;
        public int bad=0;
        public Itog()
        {
            InitializeComponent();
            Testing Test = new Testing();
            label1.Text = "Good: "+Test.good.ToString()+" Bad: "+bad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Close();
            Form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
