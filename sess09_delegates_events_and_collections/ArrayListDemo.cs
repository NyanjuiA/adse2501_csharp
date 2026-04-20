using System.Collections;

namespace sess09_delegates_events_and_collections;

/// <summary>
/// Program to demonstate the ArrayList class and some of its methods
/// </summary>
public class ArrayListDemo
{
    static void Main(string[] args)
    {
        // Declare and instantiate an ArrayList object/instance
        ArrayList fruitList = new ArrayList();

        // Display the initial capacity of the fruitList object
        Console.WriteLine($"The initial capacity of the 'fruitList' is : {fruitList.Capacity}");

        // Add fruits to the fruitList
        fruitList.Add("apple");
        fruitList.Add("orange");
        fruitList.Add("banana");
        fruitList.Add("pineapple");
        fruitList.Add("mango");
        fruitList.Add("watermelon");
        fruitList.Add("avocado");
        fruitList.Add("kiwi fruit");
        fruitList.Add("grapes");
        fruitList.Add("passion fruit");
        fruitList.Add("blueberry");
        fruitList.Add("strawberry");
        fruitList.Add("papaya");
        fruitList.Add("pomegranate");
        fruitList.Add("guava");
        fruitList.Add("pears");
        fruitList.Add("cherry");
        fruitList.Add("peach");
        fruitList.Add("durian");
        fruitList.Add("dragon fruit");

        // Display the original list of fruits
        Console.WriteLine($"The original fruitList has {fruitList.Count} fruits, and they are listed below:");
        foreach (string fruit in fruitList)
            Console.WriteLine(fruit);

        // Insert a fruit before 'mango'
        fruitList.Insert(4,"lemon");
        // Replace 'kiwi fruit' with figs
        fruitList[8] = "figs";

        // Display the modified and unsorted list of fruits
        Console.WriteLine($"The modified and unsorted 'fruitList' has {fruitList.Count} fruits, " +
                          $"and they are listed below:");
        for(uint n = 0; n < fruitList.Count; n++)
            Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");

        // Sort the 'fruitList' in reverse lexicographical (descending) order
        fruitList.Sort(); // Sort the fruits in ascending order
        fruitList.Reverse(); // Reverse the above sort (effectively sorting them in descending order)
        Console.WriteLine("The list of fruits in reverse lexicographical (descending) order are:");
        for(uint n = 0; n < fruitList.Count; n++)
            Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");
    }
}