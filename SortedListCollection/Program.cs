using System;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        { 
            SortedList<string, string> Names = new SortedList<string, string>();

            Names.Add("Doe", "John");
            Names.Add("Tulu", "Toddy");
            Names.Add("Francis", "Mike");
            Names.Add("Hadberry", "Hailey");
            Names.Add("Blue", "Benny");
  
            Console.WriteLine("Here is the list of current employees");
            foreach (KeyValuePair<string, string> bl in Names)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }

            Console.WriteLine("What employee would you like to view? (first name)");
            string employeeFirst = Console.ReadLine();

            if (Names.ContainsValue(employeeFirst))
            {
                Console.WriteLine($"{employeeFirst} is still employee, would you like to remove them from the system? yes or no.");
                string fired = Console.ReadLine();
                if (fired == "yes")
                {
                    Names.Remove(employeeFirst);
                }
            }

            Console.WriteLine("Here is the list of current employees");
            foreach (KeyValuePair<string, string> bl in Names)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
        }
    }
}