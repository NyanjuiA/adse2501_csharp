using System.Collections;

namespace sess09_delegates_events_and_collections;

/// <summary>
/// Program to demonstrate working with the SortedList class.
/// </summary>
public class SortedAccountList
{
    static void Main(string[] args)
    {
        SortedList accountDetails = new SortedList();

        // Create some dummy UserAccounts
        accountDetails.Add(10, new UserAccount("James56", "Password32&"));
        accountDetails.Add(8, new UserAccount("Nanchos29", "Secret127*3"));
        accountDetails.Add(17, new UserAccount("Light54", "Discreet_y1"));
        accountDetails.Add(4, new UserAccount("Tesfai48", "Hidden@&123"));
        accountDetails.Add(30, new UserAccount("Ciku16", "Mustard_34#"));
        accountDetails.Add(12, new UserAccount("James56", "Ihave_n01d3@"));

        // Display the keys from the sorted list
        Console.WriteLine($"Keys in the account details collection are: ");
        foreach (int key in accountDetails.Keys)
        {
            Console.WriteLine(key);
        }

        // Display the values ( each user's account details)
        Console.WriteLine($"The user account details are: ");
        foreach (UserAccount account in accountDetails.Values)
        {
            Console.WriteLine(account);
        }
    }
}