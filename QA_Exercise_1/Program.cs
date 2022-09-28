/*
Exercise 1
Create a C# console application. Upon running the application, it should display the message "Welcome to your new job!" to the user.
Create a class called Employee.The class should have three properties:
    Name(string)
    Birthday(datetime)
    Salary(decimal)
Ask the user to enter their name, birthday and Salary.
Create a new object of type Employee.Store the user's inputted information into the new object.
Write out to the user the following message: "Welcome to the company, <name>! Your salary is <salary> and your birthday is <birthday>." Obviously, replace the tokens with the user-supplied values.
BONUS: After the above message, write out to the user how many days it will be until their next birthday. "Your birthday will be in <number> days!"
BONUS 2: Add a unit test to the Employee class.

Exercise 2
Start from a completed practice assignment 1. If you haven't completed assignment 1 yet, I recommend you do that one first. Otherwise, you can start from my completed solution.
Your customer has changed the requirements of the original project. They now want you to add some additional functions beyond simply adding a new employee. Upon running your program, display the following to your user:
 Welcome to the program. Please choose from the following menu options:
Add an employee
View all current employees
Remove an employee by name
3. Implement the functionality of the 3 menu items. Item 1 should do the same thing our code did in assignment 1 -- ask the user for their Name, Birthday, and Salary, and store that information. However, we must now be able to remember the information for many employees instead of just 1. What programming structure would be good here?
4. For item 2, we need to print out the names, birthdays, and salaries of all employees on record in the following format:
 Employee <name> makes <salary> and was born on <birthday>. It is <number> days until their next birthday.
You can reuse the birthday logic from part 1 in this calculation.
5. For item 3, we need to ask the user for the name of the employee to remove, and then delete them from the record.
6. Bonus: Write a unit test for each of the 3 menu options. Keep in mind you may need to move the code out of program.cs and into another class to make it easier to unit test.
*/


using QA_Exercise_1;
// variables for storing user inputs
string input = "";
string name = "";
string bday = "";
string salary = "";
bool correctBdayInput = false;


Console.WriteLine(@"Welcome to the program. Please choose from the following menu options:
[1] Add an employee
[2] View all current employees
[3] Remove an employee by name
");
input = Console.ReadLine();



Console.WriteLine("Welcome to your new job!");



// gather necessary inputs to create Employee object
Console.WriteLine("What is your name?");
input = Console.ReadLine();
name = input;



Console.WriteLine("What is your birthday? (Month-Day-Year)");
input = Console.ReadLine();
DateTime birthday;
while (!DateTime.TryParse(input, out birthday))
{
    Console.WriteLine("Invalid birthday, please try again");
    input = Console.ReadLine();
}
bday = birthday.ToShortDateString();

// TODO: input validation for salary 
Console.WriteLine("What is your salary?");
input = Console.ReadLine();
salary = input;

// create Employee instance and print out greeting
Employee employee = new Employee(name, bday, salary);
Console.WriteLine(employee.Greeting());
int daysUntil = employee.DaysUntilBday();
if (daysUntil == 0)
    Console.WriteLine("Today is your birthday, Happy Birthday!!!");
else
    Console.WriteLine($"Your birthday will be in {daysUntil} days!");