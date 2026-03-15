  using System.Diagnostics.Metrics;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
       static public void PrintNumbers()
        {
            int counter = 1001;
            do
            {
                counter--;
                Console.WriteLine(counter);
                }while(counter > -1000);
            

        }
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        static public void PrintEveryThirdNumber()
        {
            int thirds = 3;
            do
            {
                Console.WriteLine(thirds);
                thirds += 3;
            }while(thirds < 1002);
        }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        static public bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        
        
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        static public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        static public bool IsPositive(int number2)

        {
            return number2 > 0;
        }
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        static public bool CanVote(int age)

        {
            return age >= 18;
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        static public bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        static public void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + (i * number));
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers();
            
            PrintEveryThirdNumber();
            
            Console.WriteLine("now lest compare numbers what is your first number?");
            int num1 = 
                int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            int num2 =
                int.Parse(Console.ReadLine());
            
            bool result = AreNumbersEqual(num1, num2);
            Console.WriteLine($"It is a {result} statement that your numbers are equal. ");
            
            Console.WriteLine("Lets see if you number is evan or odd what is your number? ");
            int number =
                int.Parse(Console.ReadLine());
            
            bool result2 = IsEven(number);
            Console.WriteLine($"It is a {result2} statement that your number is evan. ");

            Console.WriteLine("Now lets see if you number is positive or negative what is your number.");
            int number2 =
                int.Parse(Console.ReadLine());
            bool result3 = IsPositive(number2);
            Console.WriteLine($"It is a {result3} statement that your number is positive. ");
            
            Console.WriteLine("Now lets check to see if you can vote in the USA what is your age.");
            
            int age =
                int.Parse(Console.ReadLine());
            bool result4 = CanVote(age);
            Console.WriteLine($"It is a {result4} statement that you can vote in the USA. ");
            
            Console.WriteLine("Now in the heating up section lets see if your number is in the range of -10 and 10.");
            Console.WriteLine("What is your number.");
            int number3 =
                int.Parse(Console.ReadLine());
            bool result5 = IsInRange(number3);
            Console.WriteLine($"it is {result5} that your number is between -10 and 10.");
            
            Console.WriteLine("now lets do some multiplication what is the number you would like to multiply ");
            
            int num =
                int.Parse(Console.ReadLine());
            DisplayMultiplicationTable(num);
            
            
            
        }
    }
}
