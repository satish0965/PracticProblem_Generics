namespace GenericsProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Choose The Option Can Be Executed: ");
            Console.WriteLine("Find the Max Value Out Of Three: \n1.Integers \n2.Float \n3.String \n4.Generic Method \n5.Generic Class \n6.Exit");
            Console.Write("Enter the selected Option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            FindMaxNum findMaxNum = new FindMaxNum();

            switch (option)
            {
                case 1:
                    Console.WriteLine("For Determining Max of Integer: ");
                    Console.WriteLine("Enter the First Number: ");
                    int first_Number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Second Number: ");
                    int second_Number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Third Number: ");
                    int third_Number = Convert.ToInt32(Console.ReadLine());

                    if (findMaxNum.GetMaximumInteger(first_Number, second_Number, third_Number) != 0)
                        Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", findMaxNum.GetMaximumInteger(first_Number, second_Number, third_Number), first_Number, second_Number, third_Number);

                    break;
                case 2:
                    Console.WriteLine("For Determining Max of Float: ");
                    Console.WriteLine("Enter the First Number: ");
                    double first_Num = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Second Number: ");
                    double second_Num = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Third Number: ");
                    double third_Num = double.Parse(Console.ReadLine());

                    if (findMaxNum.GetMaximumFloat(first_Num, second_Num, third_Num) != 0.0)
                        Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", findMaxNum.GetMaximumFloat(first_Num, second_Num, third_Num), first_Num, second_Num, third_Num);
                    break;
                case 3:
                    Console.WriteLine("For Determining Max of String: ");
                    Console.WriteLine("Enter the First String: ");
                    string first_String = Console.ReadLine();
                    Console.WriteLine("Enter the Second String: ");
                    string second_String = Console.ReadLine();
                    Console.WriteLine("Enter the Third String: ");
                    string third_String = Console.ReadLine();

                    if (findMaxNum.GetMaximumstring(first_String, second_String, third_String) != null)
                        Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", findMaxNum.GetMaximumstring(first_String, second_String, third_String), first_String, second_String, third_String);
                    break;
                case 4:
                    Console.WriteLine("For Determining Max Generic Method: ");

                    int maxInt = FindMaxNum.GetMaximum<int>(1, 2, 3);
                    double maxFloat = FindMaxNum.GetMaximum<double>(1.1f, 9.4f, 5.7f);
                    string maxString = FindMaxNum.GetMaximum<string>("Apple", "Peach", "Banana");

                    Console.WriteLine(maxInt);
                    Console.WriteLine(maxFloat);
                    Console.WriteLine(maxString);

                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("For Determining Max Using Generic Class: ");

                    int maxIntclass = new FindMaxNum<int>(1, 2, 3).GetMaximum();
                    double maxFloatclass = new FindMaxNum<double>(1.1f, 9.4f, 5.7f).GetMaximum();
                    string maxStringclass = new FindMaxNum<string>("Apple", "Peach", "Banana").GetMaximum();

                    Console.WriteLine(maxIntclass);
                    Console.WriteLine(maxFloatclass);
                    Console.WriteLine(maxStringclass);
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
            Console.ReadLine();

        }
    }

}

//UC-3 Refactor-2
//Refactor to create Generic Class to take in 3 variables of Generic Type
//- Ensure the Generic Type extends Comparable
//- Write parameter constructor
//- Write testMaximum method to internally call the static testMaximum method passing the 3 instance variables
//- Define new test case to use the Generic Class

//Result

//Please Choose The Option Can Be Executed:
//Find the Max Value Out Of Three:
//1.Integers
//2.Float
//3.String
//4.Generic Method
//5.Exit
//Enter the selected Option: 4
//For Determining Max Generic Method:
//3
//9.399999618530273
//Peach