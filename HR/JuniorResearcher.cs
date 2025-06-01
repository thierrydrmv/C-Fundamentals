using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.HR
{
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string firstName, string lastName, string email, DateTime birthDay, double hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        public override void GiveBonus()
        {
            Console.WriteLine($"Junior Researcher {FirstName} {LastName} received a bonus of 220!");
        }
    }
}
