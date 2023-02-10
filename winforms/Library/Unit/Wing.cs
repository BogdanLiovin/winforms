using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Library
{
    public class Wing : Unit
    {
        public override string TypeUnit
        {
            get => "Крыло";
        }
        public decimal Wingspan;

        public Wing(decimal wingspan)
        {
            Wingspan = wingspan;
        }

        public override string ToString()
        {
            return
                String.Format(
                    "Размах крыла: {0}\n",
                    Wingspan
                );
        }
    }
}
