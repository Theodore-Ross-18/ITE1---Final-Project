
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
                        Console.Write("\nEnter Student Number: ");
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
                        genderInput gender;
                        if (genderInput == "M") {

                            gender = Gender.MALE;

                        } else if (genderInput == "F") {

                            gender = Gender.FEMALE;

                        } else {

                            // HandlingL Invalid Gender Input (Default)
                            Console.WriteLine("Invalid gender input. Using default gender.");
                            gender = Gender.MALE;
                        }

                        Console.Write("Enter Country Code: ");
                        string countryCode = Console.ReadLine();

                        Console.Write("Enter Area Code: ");
                        string areaCode = Console.ReadLine();

                        Console.Write("Enter Number: ");
                        string phoneNumber = Console.ReadLine();

                        // Creating: New Student & Adding it to the Phonebook
                        Student student = new Student
                        {
                            StudentNumber = studentNumber,
                            Surname = surname,
                            FirstName = firstName,
                            Occupation = occupation,
                            Gender = gender,
                            countryCode = countryCode,
                            AreaCode = areaCode,
                            PhoneNumber = phoneNumber
                        };

                        aseanPhonebook.AddStudent(student);

                        Console.Write("\nDo you want to enter another entry [Y/N]? ");
                        string anotherEntry = Console.ReadLine().ToUpper();

                        if (anotherEntry != "Y")
                        {
                            break;
                        }
                    }
                    // Case 1: End
                    break;

                case "2":
                    // Editing: Student Information
                    Console.Write("\nEnter Student Number: ");
                    string studentNumberToEdit = Console.ReadLine();

                    Student foundStudent = aseanPhonebook.Students.Find(student => student.StudentNumber == studentNumberToEdit);

                    if (foundStudent != null)
                    {
                        Console.WriteLine($"\nHere is the existing information about {studentNumberToEdit}: \n");
                        Console.WriteLine(foundStudent.DisplayInfo());

                        // Entering: The Edit Menu
                        while (true)
                        {
                            Console.WriteLine("\nEDIT MENU");
                            Console.WriteLine("[1] Student number\n[2] Surname\n[3] First Name\n[4] Gender\n[5] Occupation\n" +
                                              "[6] Country code\n[7] Area code\n[8] Phone number\n[9] None - Go back to the main menu");

                            Console.Write("\nEnter Choice: ");
                            string editChoice = Console.ReadLine();          
                        }

                    }
            }

        }


    }

}