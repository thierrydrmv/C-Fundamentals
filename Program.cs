using Classes;
using System.Text;

//Console.WriteLine("Creating an employee!");
//Console.WriteLine("--------------------\n");

//var carl = new Employee("Carl", "James", "carl@gmail.br", new DateTime(2000, 1, 12), 25, EmployeeType.Manager);

//carl.DisplayEmployeeDetails();

//carl.PerformWork();
//carl.PerformWork();
//carl.PerformWork(5);
//carl.PerformWork();

//double receivedWageCarl = carl.ReceiveWage();
//Console.WriteLine($"Wage paid (message from Program): {receivedWageCarl}");

//Console.WriteLine("Creating an employee!");
//Console.WriteLine("--------------------\n");

//Employee gama = new("Gama", "Odlared", "ga@gmail.br", new DateTime(1996, 1, 1), 40, EmployeeType.Research);

//string gamaAsJson = gama.ConvertToJson();
//Console.WriteLine(gamaAsJson);

//gama.DisplayEmployeeDetails();

//gama.PerformWork();
//gama.PerformWork();
//gama.PerformWork(25);
//gama.PerformWork();

//int minimalBonus = 10;
//int receivedBonus = gama.CalculateBonus(minimalBonus);
//Console.WriteLine($"The minimum bonus is {minimalBonus}, and {gama.firstName} has received a bonus of {receivedBonus}");

//int minimalBonus = 200;
//int bonusTax = 0;
//int receivedBonus = gama.CalculateBonusAndBonusTax(minimalBonus, ref bonusTax);

//Employee.ChangeTaxRate(0.2);

//gama.ReceiveWage();

//gama.DisplayEmployeeDetails();

//var example = gama.ExampleOut(out int bonusExample);
//Console.WriteLine(example); // 100
//Console.WriteLine(bonusExample); // 100
//Console.WriteLine($"The minimum bonus is {minimalBonus}, the bonus tax is  {bonusTax} and {gama.firstName} has received a bonus of {receivedBonus}");

//double receivedWageGama = gama.ReceiveWage();
//Console.WriteLine($"Wage paid (message from Program): {receivedWageGama}");

// string reference type, performance with stringbuilder

//string name = "Gama";
//string lastName = "Silva";

//StringBuilder builder = new StringBuilder();

//builder.Append("Last Name: ");
//builder.AppendLine(lastName);

//builder.Append("First Name: ");
//builder.AppendLine(name);

//string result = builder.ToString();
//Console.WriteLine(result);

//WorkTask task;
//task.description = "Climbing hard routes";
//task.hours = 4;
//task.PerformWorkTask();

//Customer customer = new();

//gama.CalculateWage();

//Account account = new("1234");

//int[] sampleArray = new int[5];

//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

//Console.WriteLine("How much books do you want to borrow?");

//int length = int.Parse(Console.ReadLine());

//string[] inputArray = new string[length];

//for (int i = 0; i < inputArray.Length; i++)
//{
//    Console.WriteLine("Write the name of the book:");
//    inputArray[i] = Console.ReadLine();
//}

//Console.WriteLine("Books List:");

//for (int i = 0;i < inputArray.Length; i++)
//{
//    Console.WriteLine($"{i} - {inputArray[i]}");
//}
//Employee alfa = new("Alfa", "Odlared", "al@gmail.br", new DateTime(1996, 1, 2), 40, EmployeeType.Research);
//Employee beta = new("Beta", "Odlared", "be@gmail.br", new DateTime(1996, 1, 3), 40, EmployeeType.Research);
//Employee delta = new("Delta", "Odlared", "de@gmail.br", new DateTime(1996, 1, 4), 40, EmployeeType.Research);
//Employee horus = new("Horus", "Odlared", "ho@gmail.br", new DateTime(1996, 1, 5), 40, EmployeeType.Research);

//Employee[] employees = new Employee[5];

//employees[0] = alfa;
//employees[1] = beta;
//employees[2] = delta;
//employees[3] = horus;
//employees[4] = gama;

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(40);
//    employee.PerformWork(numberOfHoursWorked);
//    employee.ReceiveWage();
//}

// list is a type of collections

List<int> employeeIds = new List<int>();

employeeIds.Add(21);
employeeIds.Add(24);
employeeIds.Add(26);

if (employeeIds.Contains(21))
    Console.WriteLine("21 was found!");

var employIdsArray = employeeIds.ToArray();

employeeIds.Clear();