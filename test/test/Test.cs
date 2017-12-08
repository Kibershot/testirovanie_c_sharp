using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace test
{
    public partial class Test : Form
    {
        public int p = 0;

        Cor cor = new Cor();
        public Test()
        {
            InitializeComponent();

            cot1.Hide();
            cot2.Hide();
            cot3.Hide();
            cot4.Hide();
            cot5.Hide();
            cot6.Hide();

            cor.AllVop();
            int vp = p + 1; ;
            numvop.Text = vp + " из " + cor.allVop.Length;

            double a = (double)(p) / cor.allVop.Length * 100;
            progressBar1.Value = (int)a;

            radioOpen();
            radioInput();

            labelVopros.Text = cor.Vopros(p); 
            labelOtvets.Text = cor.Otvets(p);
            p++;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)(p) / cor.allVop.Length * 100;
            progressBar1.Value = (int)a;

            int vp = p + 1; ;
            numvop.Text = vp + " из " + cor.allVop.Length; 
            

            //MessageBox.Show(p + " " + r);
            int r = cor.allVop.Length - 1;
            if (p == r)
            {
                bGo.Text = "Закончить";
            }
            if (p > r) {  this.Close(); p = 0; }

            labelVopros.Text = cor.Vopros(p);
            labelOtvets.Text = cor.Otvets(p);



            radioOpen();
            radioInput();


            //MessageBox.Show(p + " " + r);

            p++;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        public void radioOpen()
        {
            radioButton1.Show(); var1.Show();
            radioButton2.Show(); var2.Show();
            radioButton3.Show(); var3.Show();
            radioButton4.Show(); var4.Show();
            radioButton5.Show(); var5.Show();
            radioButton6.Show(); var6.Show();
        }

        public void radioInput()
        {
            if (cor.RadioInfo(p) == 2)
            {


                radioButton3.Hide(); var3.Hide();
                radioButton4.Hide(); var4.Hide();
                radioButton5.Hide(); var5.Hide();
                radioButton6.Hide(); var6.Hide();
            }
            else if (cor.RadioInfo(p) == 3)
            {
                radioButton4.Hide(); var4.Hide();
                radioButton5.Hide(); var5.Hide();
                radioButton6.Hide(); var6.Hide();
            }
            else if (cor.RadioInfo(p) == 4)
            {
                radioButton5.Hide(); var5.Hide();
                radioButton6.Hide(); var6.Hide();
            }
            else if (cor.RadioInfo(p) == 5)
            {
                radioButton6.Hide(); var6.Hide();
            }
            else if (cor.RadioInfo(p) == 1)
            {
                radioButton2.Hide(); var2.Hide();
                radioButton3.Hide(); var3.Hide();
                radioButton4.Hide(); var4.Hide();
                radioButton5.Hide(); var5.Hide();
                radioButton6.Hide(); var6.Hide();
            }
        }
    }
}
