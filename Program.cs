// See https://aka.ms/new-console-template for more information
using formulatrix_submission_01;

Service.AddRule(11, "dorr"); // Add some rules

Console.Write("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
{
    Service.Calculate(x);
}
else
{
    Console.WriteLine("Please enter a valid positive integer.");
}
