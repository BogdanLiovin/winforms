using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Route
    {
        public Route(decimal duration, string description)
        {
            Duration = duration;
            Description = description;
        }

        public decimal Duration { get; set; }
        public string Description { get; set; }
    }
}
