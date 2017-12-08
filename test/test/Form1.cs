using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test Test = new Test();
            Test.Show();
            bTest.Enabled=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Пойти нахуй?", "Путь нахуй", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) //Если нажал нет
            {
                MessageBox.Show("Иди нахуй");
            }

            if (result == DialogResult.Yes) //Если нажал Да
            {
                MessageBox.Show("Доборо пожаловать нахуй");
            }
        }
    }
}
