
namespace GenericsProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("1. Find the Max Value Out Of Three:");
           
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the First Number: ");
            int first_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int second_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number: ");
            int third_Number = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    FindMaxNum findMaxNum = new FindMaxNum();
                    if (findMaxNum.GetMaximumInteger(first_Number, second_Number, third_Number) != 0)
                        Console.WriteLine("{0} is Maximum", findMaxNum.GetMaximumInteger(first_Number, second_Number, third_Number), first_Number, second_Number, third_Number);
                    break;
                case 2:
                default:
                    break;
            }
            Console.ReadLine();

        }
    }

}

//UC-1
//Given 3 Integers find the maximum
//- Ensure to test code with the Test Case.
//- To ensure your Code works you need 3 test cases with Max Number at 1st, 2nd and 3rd
//- Use Integer Object and compareTo UC 1 method to test the maximum number

//Result

//Please Choose The Option Can Be Executed:
//1.Find the Max Value Out Of Three:
//2.Exit:
//Enter the selected Option: 1
//Enter the First Number:
//23
//Enter the Second Number:
//32
//Enter the Third Number:
//8
//32 is Maximum out of 23 ,32, 8