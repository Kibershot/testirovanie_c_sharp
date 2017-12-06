using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace testirovanie
{
    class OutVp
    {
        public int num;
        public int ot;
        public int du;

        private string s;

        Testing Test = new Testing();

        public OutVp() 
        {

        }
        public OutVp(int i)
        {
            
            
        }

        public void Open(int i)
        {
            i = num;
            StreamReader f = new StreamReader(@"vp.txt");
            string[] a = f.ReadToEnd().Split('\n');
            s = a[i];
        }

        public string Rez(int _i)
        {
            Open(num);
          String[] vp = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            return vp[_i];
        }
        public void Draw()
        {
            Open(num);
            String[] vp = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
           
        }

    }
}
