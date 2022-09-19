using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA_Exercise_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Exercise_1.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void EmployeeTest()
        {
            // Arrange
            string name = "John";
            string bday = "01-02-03"; // Jan 2nd, 2003
            string salary = "10,000";

            string expectedName = "John";
            DateTime expectedBday = new DateTime(2003, 1, 2);
            decimal expectedSalary = 10000m;

            // Act
            var employee = new Employee(name, bday, salary);

            // Assert
            Assert.AreEqual(expectedName, employee.Name);
            Assert.AreEqual(expectedBday, employee.Bday);
            Assert.AreEqual(expectedSalary, employee.Salary);

        }

        [TestMethod()]
        public void GreetingTest()
        {
            // Arrange
            string name = "John";
            string bday = "01-02-03"; // Jan 2nd, 2003
            string salary = "10,000";

            string expectedGreeting = "Welcome to the company, John! Your salary is $10,000.00 and your birthday is 1/2/2003.";

            // Act
            var employee = new Employee(name, bday, salary);

            // Assert
            Assert.AreEqual(expectedGreeting, employee.Greeting());
        }

        [TestMethod()]
        public void DaysUntilBday_BdayTomorrow()
        {
            // Arrange
            string name = "John";
            string bday = $"{DateTime.Now.Month}-{DateTime.Now.Day + 1}-{DateTime.Now.Year}" ; // bday is tomorrow
            string salary = "10,000";

            int expectedDaysUntilBday = 1;

            // Act
            var employee = new Employee(name, bday, salary);

            // Assert
            Assert.AreEqual(expectedDaysUntilBday, employee.DaysUntilBday());
        }

        [TestMethod()]
        public void DaysUntilBday_BdayYesterday()
        {
            // Arrange
            string name = "John";
            string bday = $"{DateTime.Now.Month}-{DateTime.Now.Day - 1}-{DateTime.Now.Year}"; // bday was yesterday
            string salary = "10,000";

            int expectedDaysUntilBday = 364;

            // Act
            var employee = new Employee(name, bday, salary);

            // Assert
            Assert.AreEqual(expectedDaysUntilBday, employee.DaysUntilBday());
        }

        [TestMethod()]
        public void DaysUntilBday_BdayToday()
        {
            // Arrange
            string name = "John";
            string bday = $"{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Year}"; // bday is today
            string salary = "10,000";

            int expectedDaysUntilBday = 0;

            // Act
            var employee = new Employee(name, bday, salary);

            // Assert
            Assert.AreEqual(expectedDaysUntilBday, employee.DaysUntilBday());
        }
    }
}