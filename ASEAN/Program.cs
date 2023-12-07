
// Main: Program Class
public class Program 
{
    // Main Method: Program Starts Execution
    static void Main() 
    {
        // Creating: Instance of the ASEAN Phonebook Class
        ASEANPhonebook aseanPhonebook = new ASEANPhonebook();

        while (true)
        {
            // User Interface: The Main Menu
            Console.WriteLine("\nMAIN MENU\n[1] Store to ASEAN phonebook\n[2] Edit entry in ASEAN phonebook\n" +
            "[3] Search ASEAN phonebook by country\n[4] Exit");

            Console.Write("\nEnter Choice: ");
            string choice = Console.ReadLine();

            // Switching: Based on User Choices
            switch (choice)
            {
                case "1":
                    // Adding: Students to the Phonebook
                    while (true)
                    {
                        Console.Write("\nEnter Number: ");
                        string studentNumber = Console.ReadLine();

                        Console.Write("Enter Surname: ");
                        string surname = Console.ReadLine();

                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Enter Occupation: ");
                        string occupation = Console.ReadLine();

                        Console.Write("Enter Gender (M for male, F for female): "):
                        string genderInput = Console.ReadLin().ToUpper();

                        // Conditional: Gender Input

                    }
            }

        }


    }

}