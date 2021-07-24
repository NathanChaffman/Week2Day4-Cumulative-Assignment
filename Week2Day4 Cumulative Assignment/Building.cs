using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4_Cumulative_Assignment
{
    abstract class Building
    {
        public abstract decimal AreaFunction(decimal side1, decimal side2, decimal height);
        
        private int numberOfstories;

        private string colorOfbuilding;

        //private string cityOfbuilding;

        private string materialOfbuilding;

        public int _numberOfstories 
        { 
            get 
            {
                return this.numberOfstories;
            }
            set 
            {
                this.numberOfstories = value;
            }
        }
        public string _colorOfbuilding
        {
            get
            {
                return this.colorOfbuilding;
            }
            set
            {
                this.colorOfbuilding = value;
            }
        }
//        public string _cityOfbuilding

//        {
//            get
//            {
//                return this.cityOfbuilding;
//;
//            }
//            set
//            {
//                this.cityOfbuilding = value;
//            }
//        }
        public string _materialOfbuilding
        {
            get
            {
                return this.materialOfbuilding;
            }
            set
            {
                this.materialOfbuilding = value;
            }
        }


    }
}
