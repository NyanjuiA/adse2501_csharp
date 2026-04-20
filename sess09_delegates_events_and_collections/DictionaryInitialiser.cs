using sess08_namespaces_and_exceptions;

namespace sess09_delegates_events_and_collections
{
    /// <summary>
    /// Program to demonstrate the Generic Dictionary class
    /// </summary>
    public class DictionaryInitialiser
    {
        static void Main(string[] args)
        {
            // Declare and initialise a generic dictionary of employees
            Dictionary<uint, Employee> empDictionary = new Dictionary<uint, Employee>()
            {
                {1,
                    new Employee
                    {
                        EmpID = 1005,
                        Names = "Clarion Madiba",
                        BirthDate = Convert.ToDateTime("03-02-1989"),
                        Gender = 'F',
                        Nationality = "Canadian"
                    }
                },
                {2,
                    new Employee
                    {
                        EmpID = 1007,
                        Names = "James Anderson",
                        BirthDate = Convert.ToDateTime("02-01-2001"),
                        Gender = 'M',
                        Nationality = "French"
                    }
                },
                {3,
                    new Employee
                    {
                        EmpID = 1008,
                        Names = "Emily Bernard",
                        BirthDate = Convert.ToDateTime("03-04-1999"),
                        Gender = 'F',
                        Nationality = "Nigerian"
                    }
                },
            };

            // Add a new employee
            empDictionary.Add(4,
                    new Employee
                    {
                        EmpID = 1009,
                        Names = "John Mathiukure",
                        BirthDate = Convert.ToDateTime("08-08-1988"),
                        Gender = 'F',
                        Nationality = "Kenyan"
                    }
                );

            // Display the number of keys in the employee Dictionary and their values
            Console.WriteLine($"The employee dictionary has {empDictionary.Count} keys and they are:\n");
            foreach(var key in empDictionary.Keys)
                Console.WriteLine(key);

            // Display the details of the employees in the employee dictionary
            Console.WriteLine($"\nThe details of the employees in the employees dictionary are:\n");
            foreach(var emp in empDictionary)
                Console.WriteLine(emp.Value.ToString() + 
                    $"\n" + new string('-',55));
        }
    }
}
