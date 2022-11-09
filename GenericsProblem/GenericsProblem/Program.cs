namespace GenericsProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Choose The Option Can Be Executed: ");
            Console.WriteLine("Find the Max Value Out Of Three: \n1.Integers \n2.Float \n3.String \n4.Exit");
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
                default:
                    break;
            }
            Console.ReadLine();

        }
    }

}

//UC-3
//Given 3 Strings find the maximum
//- Ensure to test code with the Test Case and repeat with the similar 3 Test cases in UC 1
//- E.g. Apple Peach Banana

//Result

//Please Choose The Option Can Be Executed:
//Find the Max Value Out Of Three:
//1.Integers
//2.Float
//3.String
//4.Exit
//Enter the selected Option: 3
//For Determining Max of String:
//Enter the First String:
//Apple
//Enter the Second String:
//Peach
//Enter the Third String:
//Banana
//Peach is Maximum out of Apple , Peach, Banana