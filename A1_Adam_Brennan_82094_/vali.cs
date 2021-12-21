using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program checks for validation
namespace A1_Adam_Brennan_82094_
{
    public static class vali
    {
        public static string check(string val)
        {
            double check = double.Parse(val);
            if (check < 0) // sees if number is negative
            {
                return 1.ToString(); // returns 1 if negative
            }
            else
            {
                return 0.ToString(); // returns 0 if false
            }
        }
    }

}