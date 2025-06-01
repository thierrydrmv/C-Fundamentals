using BethanysPieShopHRM.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.HR
{
    public class Employee : IEmployee
    {
        public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(firstName, lastName, email, birthDay, 0)
        {
            
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate;
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate;

            Address = new Address(street, houseNumber, zip, city);
        }

        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private int numberOfHoursWorked { get; set; }
        private double wage { get; set; }
        private double? hourlyRate { get; set; }

        private DateTime birthDay { get; set; }
        private const int minimalHoursWorkedUnit = 1;
        private static double taxRate = 0.15;
        private Address address;
        
        public string FirstName
        {
            get {  return firstName; } 
            set 
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            // protected allow acess from the inheritor
            protected set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                wage = value;
            }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0)
                    hourlyRate = 0;
                else
                    hourlyRate = value;
            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        public static void ChangeTaxRate(double newTaxRate)
        {
            taxRate = newTaxRate;
        }

        public void PerformWork(int numberOfHours = minimalHoursWorkedUnit)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

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
            Wage = NumberOfHoursWorked * HourlyRate.Value;
            double wageAfterTax = Wage * taxRate;
            Console.WriteLine($"{firstName} {lastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work. The wage after tax is {wageAfterTax}.");

            if (resetHours)
                NumberOfHoursWorked = 0;
            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{BirthDay.ToShortDateString()}\nTax rate: \t{taxRate}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"Good morning, {firstName}");
        }
    }
}
