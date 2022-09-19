using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Exercise_1
{
    internal class Employee
    {
        string name;
        DateTime bday;
        decimal salary;

        public Employee(string name, DateTime bday, decimal salary)
        {
            this.name = name;
            this.bday = bday;
            this.salary = salary;
        }

        public void PrintGreeting()
        {
            string formattedName = name;
            string formattedSalary = salary.ToString("N");
            string formattedBday = bday.Date.ToShortDateString();
            Console.WriteLine($"Welcome to the company, {formattedName}! Your salary is ${formattedSalary} and your birthday is {formattedBday}.");
        }

        public void PrintDaysUntilBday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBday = new DateTime(today.Year, bday.Month, bday.Day);

            if (nextBday < today)
                nextBday = new DateTime(today.Year + 1, bday.Month, bday.Day);

            int daysUntil = (nextBday - today).Days;

            if (daysUntil == 0)
                Console.WriteLine("Today is your birthday, Happy Birthday!!!");
            else
                Console.WriteLine($"Your birthday will be in {daysUntil} days!");
        }
    }
}
