using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Factory
    {
        public Factory(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
