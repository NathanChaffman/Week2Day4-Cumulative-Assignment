using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4_Cumulative_Assignment
{
    class Mall:Building
    {
        public override decimal AreaFunction(decimal side1, decimal side2, decimal height)
        {
            return side1 * side2 * height;
        }
        public int _storesInside { get; set; }
        public int _fountainsInside { get; set; }
        public string _mallName { get; set; }
    }
}
