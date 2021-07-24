using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4_Cumulative_Assignment
{
    class Courthouse:Building
    {
        public override decimal AreaFunction(decimal side1, decimal side2, decimal height)
        {
            return side1 * side2 * height;
        }
        public int _numberOfcolumns { get; set; }
        public int _numberOflions { get; set; }
        public int _numberOfcourtrooms { get; set; }
    }
}
