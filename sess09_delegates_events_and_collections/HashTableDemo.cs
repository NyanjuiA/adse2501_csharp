using System.Collections;
using sess07_properties_records_indexers;


/// <summary>
/// Program to demonstrate the HashTable class.
/// </summary>
public class HashTableDemo
{
    static void Main(string[] args)
    {
        uint n = 0;
        Hashtable bookTable = new Hashtable();
        bookTable.Add(101, new Book(578, "C# How to Program", "Deitel & Deitel", 7100.0f));
        bookTable.Add(102, new Book(579, "C# Notes for Professionals", "Et al", 0.0f));
        bookTable.Add(103, new Book(580, "Java the Complete Reference", "Oracle Inc.", 11710.4f));
        bookTable.Add(104, new Book(581, "Web Scraping with Python", "Ryan Mitchelle", 5930.0f));
        bookTable.Add(105, new Book(582, "Fundamentals of Web Development", "Randy & Ricardo", 9700.0f));

        // Display the number of books in the books hashtable
        Console.WriteLine($"The number of books in the dictionary is: {bookTable.Count}");

        // Get a collection of keys from the books hashtable
        ICollection bookTableKeys = bookTable.Keys;
        // Display the bookTable keys
        Console.WriteLine("The keys in the Hashtable are: " +
                          "\n" + new string('-',55));
        foreach (var key in bookTableKeys)
            Console.WriteLine($"Key {++n:00}: {key}");

        // Display the keys and their corresponding values
        Console.WriteLine($"Keys and Values in the books hashtable are:");
        DisplayHashtableContents(bookTable);

        // Remove the details for key 104
        if (bookTable.Contains(104))
        {
            bookTable.Remove(104);
            Console.WriteLine($"Removed details for record 104.");
        }
        else
            Console.WriteLine("Sorry, record 104 doesn't exist.\nKindly confirm and try again.");

        // Display the hashtable contents after removing record 104
        Console.WriteLine("\nThe contents fo the books hashtable after removing key 104 are:\n");
        DisplayHashtableContents(bookTable);

        // Display some properties of the books hashtable
        Console.WriteLine($"The books hashtable is read-only: {bookTable.IsReadOnly}");
        Console.WriteLine($"The books hashtable fixed size: {bookTable.IsFixedSize}");
    }

    private static void DisplayHashtableContents(Hashtable bookTable)
    {
        IDictionaryEnumerator bookEnumerator = bookTable.GetEnumerator();
        while (bookEnumerator.MoveNext())
            Console.WriteLine($"Key:  {bookEnumerator.Key} \nValue: {bookEnumerator.Value.ToString()}");
    }
}