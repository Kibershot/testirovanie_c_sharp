using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace testirovanie
{
     
    public partial class Testing : Form
    {

        string s;
        public string[] a;
        int i=0;
        int otv_p = 0;
        public int good = 0;
        public int bad = 0;
        //public List<int> bad = new List<int>();

        OutVp Out = new OutVp();
        

        public Testing()
        {
            InitializeComponent();
            Out.num = 0;
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();


            StreamReader f = new StreamReader(@"vp.txt");
            a = f.ReadToEnd().Split('\n');
            String s = a[0];
            String[] vp = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            label1.Text = Out.Rez(0);
            label2.Text = Out.Rez(1);
            label3.Text = Out.Rez(2);
            label4.Text = Out.Rez(3);
            if (vp.Length==5)
            {
                radioButton4.Show();
                label5.Text = Out.Rez(4);
            }
            else
            {
                label5.Text=" ";
                radioButton4.Hide();
            }
            string otv;
            otv = vp[1];
            if (otv[0] == '$')
            {
                otv_p = 1;
            }
            otv = vp[2];
            if (otv[0] == '$')
            {
                otv_p = 2;
            }
            otv = vp[3];
            if (otv[0] == '$')
            {
                otv_p = 3;
            }
            if (vp.Length == 5)
            {
                otv = vp[4];
                if (otv[0] == '$')
                {
                    otv_p = 4;
                }
            }
            //int i = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Out.num++;
            label6.Text = otv_p.ToString()+" "+bad.ToString();
            //Itog itog = new Itog();
            if (radioButton1.Checked==true) {
                if (otv_p == 1)
                {
                    good++;
                }
                else bad++;  //bad.Add(i);
            }
            if (radioButton2.Checked == true)
            {
                if (otv_p == 2)
                {
                    good++;
                }
                else bad++; //bad.Add(i);
            }
            if (radioButton3.Checked == true)
            {
                if (otv_p == 3)
                {
                    good++;
                }
                else bad++;  //bad.Add(i);
            }
            if (radioButton4.Checked == true)
            {
                if (otv_p == 4)
                {
                    good++;
                }
                else bad++;  //bad.Add(i);
            }

            i++;
            if (a.Length <= i)
            {
                Itog Itog = new Itog();
                this.Close();
                Itog.Show();
            }
            else
            {

                s = a[i];
                String[] vp = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                radioButton1.Checked = true;
                label1.Text = vp[0];
                label2.Text = vp[1];
                label3.Text = vp[2];
                label4.Text = vp[3];
                label4.Text = vp[3];
                if (vp.Length == 5)
                {
                    radioButton4.Show();
                    label5.Text = vp[4];
                }
                else
                {
                    label5.Text = " ";
                    radioButton4.Hide();
                }

                string otv;
                otv = vp[1];
                if (otv[0] == '$')
                {
                    otv_p = 1;
                }
                otv = vp[2];
                if (otv[0] == '$')
                {
                    otv_p = 2;
                }
                otv = vp[3];
                if (otv[0] == '$')
                {
                    otv_p = 3;
                }
                if (vp.Length == 5) {
                    otv = vp[4];
                    if (otv[0] == '$')
                    {
                        otv_p = 4;
                    }
                }
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        public string LabelText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }
    }
}
