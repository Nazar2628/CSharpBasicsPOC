using System;

namespace CSharpBasicsPOC
{
    // Define a simple class
    public class Person
    {
        // Fields
        public string? Name;
        public int? Age;

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Variables and Data Types
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a double:");
            double pi = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a string:");
            string message = Console.ReadLine();

            Console.WriteLine("Enter a boolean (true/false):");
            bool isCSharpFun = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nVariables and Data Types:");
            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"Double: {pi}");
            Console.WriteLine($"String: {message}");
            Console.WriteLine($"Boolean: {isCSharpFun}");

            // Control Structures
            Console.WriteLine("\nControl Structures:");

            // if-else statement
            if (isCSharpFun)
            {
                Console.WriteLine("C# is fun!");
            }
            else
            {
                Console.WriteLine("C# is not fun.");
            }

            // switch statement
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is ten.");
                    break;
                default:
                    Console.WriteLine("Number is not ten.");
                    break;
            }

            // for loop
            Console.WriteLine("For loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // while loop
            Console.WriteLine("While loop:");
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine(count);
                count++;
            }

            // Methods
            Console.WriteLine("\nMethods:");
            int result = Add(number, 7); // Using the input number
            Console.WriteLine($"{number} + 7 = {result}");

            // Classes and Objects
            Console.WriteLine("\nClasses and Objects:");

            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            Person person = new Person(userName, userAge);
            person.Greet();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        // Method definition
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
