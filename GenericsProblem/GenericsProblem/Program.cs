namespace GenericsProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Choose The Option Can Be Executed: ");
            Console.WriteLine("Find the Max Value Out Of Three: \n1.Integers \n2.Float \n3.Exit");
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

                    if (findMaxNum.GetMaximumFloat(first_Num, second_Num, third_Num) != 0)
                        Console.WriteLine("{0} is Maximum out of {1} ,{2}, {3}", findMaxNum.GetMaximumFloat(first_Num, second_Num, third_Num), first_Num, second_Num, third_Num);
                    break;
                case 3:
                default:
                    break;
            }
            Console.ReadLine();

        }
    }

}

//UC-2
//Given 3 Integers find the maximum
//Given 3 Floats find the maximum
//- Ensure to test code with the Test Case and repeat with similar 3 test cases in UC-1

//Result

//Please Choose The Option Can Be Executed:
//Find the Max Value Out Of Three:
//1.Integers
//2.Float
//3.Exit
//Enter the selected Option: 2
//For Determining Max of Float:
//Enter the First Number:
//4.8
//Enter the Second Number:
//5.9
//Enter the Third Number:
//4.9
//5.9 is Maximum out of 4.8 ,5.9, 4.9