using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Chassis : Unit
    {
        internal int NumberWheels;
        public override string TypeUnit
        {
            get => "Шасси";
        }
        public Chassis()
        {
        }

        public Chassis(int numberWheels)
        {
            NumberWheels = numberWheels;
        }

        public override string ToString()
        {
            return
                String.Format(
                    "Количество колес: {0}\n",
                    NumberWheels
                );
        }
    }
}
