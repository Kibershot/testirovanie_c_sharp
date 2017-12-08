using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace test
{

    class Cor
    {
        private int a;
        private int b;
        public string[] allVop;

        public Cor()
        {
                

        }
        public void AllVop()
        {
            StreamReader f = new StreamReader(@"vp.txt");
            string[] a = f.ReadToEnd().Split('\n');
            allVop = a;
        }

        public string Vopros(int _i)
        {
            String s = allVop[_i];
            String[] vp = s.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries);

            return vp[0];
        }
        public string Otvets(int _i)
        {
            String s = allVop[_i];
            String[] vp = s.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries);
            Regex rgx = new Regex("[|]");
            string otv = rgx.Replace(vp[1], "\n\n");
            Regex rgx2 = new Regex("[$]");
            otv = rgx2.Replace(otv, "");
            return otv;
        }
        public int RadioInfo(int _i) {
            //if (_i > allVop.Length-1) return 0;
            String s = allVop[_i];
            String[] vp = s.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries);
            String[] vop_r = vp[1].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            if (vop_r.Length == 2)
            {
                return 2;
            }
            else if (vop_r.Length == 3)
            {
                return 3;
            }
            else if (vop_r.Length == 4)
            {
                return 4;
            }
            else if (vop_r.Length == 5)
            {
                return 5;
            }
            else if (vop_r.Length == 6)
            {
                return 6;
            }
            return 1;

        }

    }
}
