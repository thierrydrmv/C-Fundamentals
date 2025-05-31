using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.HR
{
    public class Employee
    {
        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0, EmployeeType.StoreManager)
        {
            
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate, EmployeeType empType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;
            this.hourlyRate = hourlyRate;
            employeeType = empType;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int numberOfHoursWorked { get; set; }
        public double wage { get; set; }
        public double hourlyRate { get; set; }

        public EmployeeType employeeType;
        public DateTime birthDay { get; set; }
        const int minimalHoursWorkedUnit = 1;
        private static double taxRate = 0.15;

        public static void ChangeTaxRate(double newTaxRate)
        {
            taxRate = newTaxRate;
        }

        public void PerformWork(int numberOfHours = minimalHoursWorkedUnit)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            if (bonus >= 200 && employeeType != EmployeeType.Research)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on is {bonusTax}");
            return bonus;
        }

        public int ExampleOut( out int bonusExample)
        {
            bonusExample = 100;
            return bonusExample;
        }

        public double CalculateWage()
        {
            WageCalculations wageCalculations = new();
            double calculatedValue = wageCalculations.ComplexWageCalculation(wage, taxRate, 3, 42);
            return calculatedValue;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            double wageAfterTax = wage * taxRate;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work. The wage after tax is {wageAfterTax}.");

            if (resetHours)
                numberOfHoursWorked = 0;
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\nTax rate: \t{taxRate}");
        }
    }
}
