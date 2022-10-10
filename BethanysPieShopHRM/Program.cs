

using BethanysPieShopHRM;
using System.Text;

//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of a: {a} and a value of copy of a: {aCopy}");
//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and a value of copy of a: {aCopy}");

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.de", new DateTime(1979, 1, 16), 25);

//bethany.PerformWork(25);

string name = "bethany";
string anotherName = name;
name += " smith";

Console.WriteLine("Name: " + name);
Console.WriteLine("Another name: " + anotherName);

string upperCaseName = name.ToUpper();

Console.WriteLine("Name: " + name);
Console.WriteLine("Uppercase name: " + upperCaseName);

string indexes = string.Empty;

for (int i= 0; i <2500; i++)
{
    indexes += indexes.ToString();
}

string firstName = "Bethany";
string lastName = "Smith";

StringBuilder builder = new StringBuilder();

builder.Append("Last name: ");
builder.AppendLine(lastName);
builder.Append("First name: ");
builder.Append(firstName);
string result = builder.ToString();

StringBuilder builder2 = new StringBuilder();

for (int i = 0; i < 1000;i++)
{
    builder2.Append(i);
    builder2.Append(" ");
}
string list = builder2.ToString();

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

//int minimumBonus = 100;
//int bonusTax = 0;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

//Employee testEmployee = bethany;
//testEmployee.firstName = "Gill";
//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();


//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//bethany.PerformWork();

//bethany.firstName = "John";
//bethany.hourlyRate = 10;

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(10);
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork();

//string fn = bethany.firstName;

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");


//Employee george = new("George", "Jones", "george@snowball.de", new DateTime(1948, 3, 28), 30);

//george.DisplayEmployeeDetails(); ;
//george.PerformWork();
//george.PerformWork(3);
//george.PerformWork();
//george.PerformWork();
//george.PerformWork(8);

//var receivedWageGeorge = george.ReceiveWage(true);
