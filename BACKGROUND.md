# ***Background***

> `Southeast Asia has 11 countries. If you have a classmate or schoolmate from this area, and you want to contact him/her, you can make an international call. Typically, to make that call, the country code has first to be dialed before the telephone number. Take note of the following ASEAN countries with their corresponding country codes (for the purposes of this assignment, let's limit to 5 ASEAN countries only)`

| `ASEAN Country` | `Country Code`    |
| :---:   | :---: |
| Federation of Malaysia | 60 |
| Republic of Indonesia | 62 |
| Republic of Philippines | 63 |
| Republic of Singapore | 65 |
| Kingdom of Thailand | 66 |

> In the ASEAN phone-book that you are to create, there should be no limit on the number of students to be stored in it.

> First, there should be a main menu, as shown below. If the user selects an invalid option, the menu should keep on showing.

```
MAIN MENU

[1] Store to ASEAN phonebook
[2] Edit entry in ASEAN phonebook
[3] Search ASEAN phonebook by country
[4] Exit
```

### STORE TO ASEAN PHONEBOOK

> Now, ask the user for the information of an individual. Here it goes:

Example
```
Enter student number: 2004-56
Enter surname: Lee
Enter first name: Sukarno
Enter occupation: Doctor
Enter gender (M for male, F for female): M
Enter area code: 2
Enter number: 4567890
Do you want to enter another entry [Y/N]? N
```
> After entering all information, ask the user whether he wants to add another entry, in which case a new set of prompting should happen. Otherwise, go back to the main menu.

### EDIT ENTRY IN ASEAN PHONEBOOK

> Ask the user first for the student number. If it does not exist, alert an error. Otherwise, editing should proceed, as displayed below (the "Edit menu"):

```
Enter student number: 2004-56
Here is the existing information about 2004-56:
Sukarno Lee is a Doctor. His number is 63-2-4567890

Which of the following information do you wish to change?

[1] Student number 
[2] Surname 
[3] Gender 
[4] Occupation 
[5] Country code 
[6] Area code
[7] Phone number
[8] None - Go back to main menu
```

Example
```
Enter choice: 1
Enter new student number: 2005-67
```

> After the new information has been entered, the 'edit menu" should again show, now displaying the modified information. The said menu should keep on showing until the user selects 8.

### SEARCH ASEAN PHONEBOOK BY COUNTRY

> The user can also view students only from specified countries. He can select single or multiple countries. Once the countries are chosen, print all the students (with their corresponding information) from those countries. Printed student-entries should be alphabetically arranged according to surname. Furthermore, if [6] ALL is selected, all students from all countries should he shown. Follow this:

```
From which country:

[1] Philippines
[2] Thailand
[3] Singapore
[4] Indonesia
[5] Malaysia
[6] ALL
[0] No More

Enter choice 1: 1
Enter choice 2: 2
Enter choice 3: 0 (If zero is entered, that means, no more countries are to be included in the search)
```

Example
```
Here are the students from 1 and 2:

Philippines:

Saint, John, with student number 2000-123, is a doctor. His phone number is 63-2-9998765

Dela Cruz, Juliana, with student number 1991-000, is a princess. Her phone number is 63-6-678123890

Thailand:

Krap, Sawadi, with student number 1999-890, is a sorcerer. His phone number is 66-8-1234567
```


