using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{

    public class FindMaxNum
    {
        public  int GetMaximumInteger(int first_Number, int second_Number, int third_Number)
        {
            if (first_Number.CompareTo(second_Number) > 0 && first_Number.CompareTo(third_Number) > 0)
                return first_Number;
            else if (second_Number.CompareTo(first_Number) > 0 && second_Number.CompareTo(third_Number) > 0)
                return second_Number;
            else if (third_Number.CompareTo(first_Number) > 0 && third_Number.CompareTo(second_Number) > 0)
                return third_Number;
            else
            {
                Console.WriteLine("\tEither 2 or 3 having same value/equals");
                return 0;
            }

        }

    }

}