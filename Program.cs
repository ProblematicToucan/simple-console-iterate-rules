// See https://aka.ms/new-console-template for more information
using formulatrix_submission_01;

Console.Write("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
{
    Service.Calculate(x);
}
else
{
    Console.WriteLine("Please enter a valid positive integer.");
}
