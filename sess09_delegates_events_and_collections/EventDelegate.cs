namespace sess09_delegates_events_and_collections;

/// <summary>
/// Program to demonstrate how to work with delegates and events.
/// </summary>

// Define the delegate for the event handler outside the class
public delegate void MyEventHandler(string value);
public class EventDelegate
{
    static void Main(string[] args)
    {
        // Declare and instantiate an EventPublisher object
        EventPublisher eventPub = new EventPublisher();
        // Assign the EventPublisher object to the UserStringChanged method
        eventPub.valueChanged += UserStringChanged;

        // String variable to hold the string/input fromthe user
        string userString;
        do
        {
            // Prompt the user for a string
            Console.WriteLine("Please enter some text or type 'exit' to " +
                              "end/quit the application.");
            userString = Console.ReadLine();
            // Display the string if it's not exit
            if (!userString.ToUpper().Equals("EXIT"))
                eventPub.Value = userString;
        } while (!userString.ToLower().Equals("exit"));
        Console.WriteLine("Goodbye!");

        // class method to handle the event of the user typing in a new string on the console
        static void UserStringChanged(string newInput)
        {
            Console.WriteLine($"The user has typed: \"{newInput}\"\n");
        }

    }
}

/// <summary>
/// Class that will be used to publish events
/// </summary>
internal class EventPublisher
{
    private string _val;

    // Declare the event
    public event MyEventHandler valueChanged;

    public string Value
    {
        set
        {
            // Set the value of the private string '_val' to the string passed in
            this._val = value;
            // When the string value changes, fire/trigger the event
            this.valueChanged(_val);
        }
    }
}