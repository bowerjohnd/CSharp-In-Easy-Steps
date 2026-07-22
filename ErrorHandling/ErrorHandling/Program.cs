Console.Title = "ErrorHandling";

Console.Write("Please Enter A Number: ");
try
{
	double num1 = Convert.ToInt16(Console.ReadLine());

	Console.Write("Now Enter Another Number: ");
	double num2 = Convert.ToInt16(Console.ReadLine());

	Console.WriteLine("Total: " + (num1 + num2));
}
//catch (OverflowException)
//{
//	Console.WriteLine("\nMaximum: " + Int16.MaxValue);
//}
catch (Exception error)
{
	Console.WriteLine(error.Message + "\n" + error.GetType());
}
