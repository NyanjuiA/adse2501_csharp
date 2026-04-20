namespace sess09_delegates_events_and_collections;

/// <summary>
/// Program to demonstrate working with a multicast delegate
/// </summary>

// Declare a delegate outside the class
public delegate void MulticastCalc(int num1, int num2);
public class MulticastDelegate
{
    // class/static methods
    static void AddNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
    }

    static void MultiplyNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} x {num2} = {(num1 * num2)}");
    }

    static void SubtractNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} - {num2} = {(num1 - num2)}");
    }

    static void DivideNums(int num1, int num2)
    {
        Console.WriteLine($"{num1} ÷ {num2} = {(num1 / num2)}");
    }

    static void GetRemainder(int num1, int num2)
    {
        Console.WriteLine($"{num1} % {num2} = {(num1 % num2)}");
    }

    static void Main(string[] args)
    {
        // Declare and instantiate the multicast delegate
        MulticastCalc mathOperation = new MulticastCalc(AddNums); // Pass the 1st method reference
        // Add the other class method references
        mathOperation += MultiplyNums;
        mathOperation += SubtractNums;
        mathOperation += DivideNums;
        mathOperation += GetRemainder;

        // Prompt the user for the numbers to be used for the calculations
        Console.WriteLine($"Please enter the first number to be used in the calculation");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Please enter the second number to be used in the calculation");
        int num2 = int.Parse(Console.ReadLine());

        // Perform and display the results of the various arithmetic operations
        mathOperation(num1, num2);

        // Remove the Multiply and Remainder(modulus) operations
        Console.WriteLine($"\nRemoving the multiplicatio and remainder methods...");
        mathOperation -= MultiplyNums;
        mathOperation -= GetRemainder;

        // Perform and display the results of the various arithmetic operations
        mathOperation(num1, num2);
    }
}