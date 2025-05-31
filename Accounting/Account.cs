using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Accounting
{
    //public record Account
    //{
    //    public string accountNumber { get; set; }
    //    public string AccountNumber
    //    {
    //        get { return accountNumber; }
    //        set
    //        {
    //            accountNumber = value;
    //        }
    //    }
    //}
    public record Account(string AccountNumber);
}
