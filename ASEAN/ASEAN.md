## Essential Parts of the Code:

1. **Main Class (`Program`):**
   - **Main Method (`Main`):**
     - **Phonebook Initialization:**
       - Creates an instance of the `ASEANPhonebook` class named `aseanPhonebook`.
     - **Menu Loop:**
       - Presents a menu with options to store entries, edit entries, search by country, or exit.
       - Accepts user input to navigate through menu options.
       - Utilizes a `while (true)` loop for the main menu, providing an option to exit the program (`case "4"`).
       - Uses a switch statement to handle different user choices.

2. **Enumerations and Classes:**
   - **`Gender` Enumeration:**
     - Represents the gender of a student (MALE, FEMALE).
   - **`Student` Class:**
     - Defines properties for student information.
     - Includes a `DisplayInfo` method to print formatted student information.
   - **`ASEANPhonebook` Class:**
     - Represents the phonebook for ASEAN countries.
     - Contains a list of `Student` objects.
     - Provides methods to add students and search for students by country.

3. **Phonebook Operations:**
   - **Add Student (`case "1"`):**
     - Accepts user input to add students to the phonebook.
     - Utilizes a nested `while (true)` loop to add multiple entries until the user chooses to stop.
   - **Edit Student (`case "2"`):**
     - Accepts user input for the student number to edit.
     - Provides an edit menu with options to modify different aspects of student information.
     - Utilizes nested loops to navigate through the edit menu.
   - **Search by Country (`case "3"`):**
     - Calls the `SearchByCountry` method in the `ASEANPhonebook` class.
     - Prompts the user to select countries and displays information about students from the selected countries.

4. **Additional Components:**
   - **User Input Handling:**
     - Uses `Console.ReadLine()` to get user input for various operations.
   - **Error Handling:**
     - Handles invalid inputs gracefully, providing default values or error messages.
   - **Exiting the Program:**
     - Uses `Environment.Exit(0)` to exit the program cleanly.

5. **Supporting Classes:**
   - **`Student` Class:**
     - Represents an individual student with properties for various details.
     - Includes a method to display formatted information.

6. **Supporting Methods:**
   - **`ASEANPhonebook` Methods:**
     - `AddStudent`: Adds a student to the phonebook.
     - `SearchByCountry`: Searches and displays student information based on selected countries.

7. **Data Structures:**
   - **`Dictionary<string, string>` (`countryCodes`):**
     - Stores ASEAN country names and their corresponding country codes.

8. **Loops:**
   - **Nested Loops:**
     - Used for handling repeated tasks, such as adding multiple entries or navigating the edit menu.
     - `while (true)` loops for the main menu and submenus.

9. **Switch Statements:**
   - Used for handling different cases based on user input in the main menu and edit menu.

10. **Enums:**
    - **`Gender` Enum:**
      - Represents the gender of a student with values MALE and FEMALE.

11. **User Interface:**
    - Utilizes `Console.WriteLine` and `Console.Write` to display information and interact with the user.
