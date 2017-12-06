using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace testirovanie
{
    class OutVp
    {
        public OutVp() 
        {

        }
        public OutVp(int i)
        {
            StreamReader f = new StreamReader(@"vp.txt");
            string[] a = f.ReadToEnd().Split('\n');
            String s = a[i];
            String[] vp = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public bool Rez(int _i)
        {
            return true;
        }

    }
}
