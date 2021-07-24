using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4_Cumulative_Assignment
{
    class Restaurant:Building
    {
        public override decimal AreaFunction(decimal side1, decimal side2, decimal height)
        {
            return side1 * side2 * height;
        }
        public string _typeOfcuisine { get; set; }
        public int _dinerCount { get; set; }
        public decimal _costofEating { get; set; }
    }
}
