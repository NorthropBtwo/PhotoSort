using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.IO;


namespace Fotosort
{
    class CFotoelement : IComparable
    {
        public string Oldname = "";
        public string Newname = "";
        public string Aufnahmedatum = "";

        public CFotoelement(string Oldname, string Aufnahmedatum)
        {
            this.Oldname = Oldname;
            this.Aufnahmedatum = Aufnahmedatum;
        }


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            CFotoelement otherFotoelement = obj as CFotoelement;
            if (otherFotoelement != null)
                return this.Aufnahmedatum.CompareTo(otherFotoelement.Aufnahmedatum);
            else
                throw new ArgumentException("Object is not a Temperature");
        }
    }
}
