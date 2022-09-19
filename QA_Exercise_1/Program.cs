/*
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
*/


using QA_Exercise_1;

Console.WriteLine("Welcome to your new job!");

// variables for storing user inputs
string input = "";
string name = "";
string bday = "";
string salary = "";

// gather necessary inputs to create Employee object
Console.WriteLine("What is your name?");
input = Console.ReadLine();
name = input;

Console.WriteLine("What is your birthday? (Month-Day-Year)");
input = Console.ReadLine();
bday = input;


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