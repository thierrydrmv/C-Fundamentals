using Classes.Accounting;
using Classes.HR;

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

Console.WriteLine("Creating an employee!");
Console.WriteLine("--------------------\n");

Employee gama = new("Gama", "Odlared", "al@gmail.br", new DateTime(1996, 1, 21), 40, EmployeeType.Research);

string gamaAsJson = gama.ConvertToJson();
Console.WriteLine(gamaAsJson);

//gama.DisplayEmployeeDetails();

gama.PerformWork();
gama.PerformWork();
gama.PerformWork(25);
gama.PerformWork();

//int minimalBonus = 10;
//int receivedBonus = gama.CalculateBonus(minimalBonus);
//Console.WriteLine($"The minimum bonus is {minimalBonus}, and {gama.firstName} has received a bonus of {receivedBonus}");

int minimalBonus = 200;
int bonusTax = 0;
int receivedBonus = gama.CalculateBonusAndBonusTax(minimalBonus, ref bonusTax);

Employee.ChangeTaxRate(0.2);

gama.ReceiveWage();

gama.DisplayEmployeeDetails();

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

WorkTask task;
task.description = "Climbing hard routes";
task.hours = 4;
task.PerformWorkTask();

//Customer customer = new();

gama.CalculateWage();

Account account = new("1234");
