using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Methods
    {
        public int Add (int numA, int numB) 
        {
            return numA + numB;
        }

        public double Add (double numA, double numB) 
        {
            return (numA + numB);
        }

        public string Add (int numA, int numB, bool condition) 
        {
            string result = "";

            if (condition) 
            {
                int sum = numA + numB;

                if (sum == 1)
                {
                    result = sum.ToString() + " Dollar";
                }

                else 
                {
                    result = sum.ToString() + " Dollars";
                }
            }

            return result;
        }
    }
}
