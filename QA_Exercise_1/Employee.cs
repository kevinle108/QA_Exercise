using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Exercise_1
{
    public class Employee
    {
        string _name;
        DateTime _bday;
        decimal _salary;

        public string Name { get => _name; set => _name = value; }
        public DateTime Bday { get => _bday; set => _bday = value; }
        public decimal Salary { get => _salary; set => _salary = value; }        

        public Employee(string name, string bday, string salary)
        {
            this.Name = name;
            this.Bday = DateTime.Parse(bday);
            this._salary = decimal.Parse(salary);
        }

        public string Greeting()
        {
            string formattedName = Name;
            string formattedSalary = _salary.ToString("N");
            string formattedBday = Bday.Date.ToShortDateString();
            return $"Welcome to the company, {formattedName}! Your salary is ${formattedSalary} and your birthday is {formattedBday}.";
        }

        public int DaysUntilBday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBday = new DateTime(today.Year, Bday.Month, Bday.Day);

            if (nextBday < today)
                nextBday = new DateTime(today.Year + 1, Bday.Month, Bday.Day);

            int daysUntil = (nextBday - today).Days;

            return daysUntil;
        }
    }
}
