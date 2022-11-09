using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{

    public class FindMaxNum
    {
        public int GetMaximumInteger(int first_Number, int second_Number, int third_Number)
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
        //UC 2: Given 3 Floats Find The Maximum.
        public double GetMaximumFloat(double first, double second, double third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("\teither 2 or 3 having same value/equals");
                return 0.0;
            }


        }
        //UC 3: Given 3 Strings Find The Maximum.
        public string GetMaximumstring(string first_String, string second_String, string third_String)
        {
            if (first_String.CompareTo(second_String) > 0 && first_String.CompareTo(third_String) > 0)
            {
                return first_String;
            }
            else if (second_String.CompareTo(first_String) > 0 && second_String.CompareTo(third_String) > 0)
            {
                return second_String;
            }
            else if (third_String.CompareTo(first_String) > 0 && third_String.CompareTo(second_String) > 0)
            {
                return third_String;
            }
            else
            {
                Console.WriteLine("\teither 2 or 3 values are equal");
                return null;
            }
        }
    }
}
