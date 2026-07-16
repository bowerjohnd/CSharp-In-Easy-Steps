Console.Title = "Manipulate";

Console.Write("Please Enter Text: ");
string text = Console.ReadLine();

Console.Write("\nThanks. You Entered:\n'" + text + "'");

text = text.Trim();
Console.Write("\nTrimmed:\t'" + text + "'");
Console.WriteLine("\tText Length: " + text.Length);

string upper = text.ToUpper();
Console.WriteLine("\nUpperCase:\t'" + upper + "'");

string lower = text.ToLower();
Console.WriteLine("LowerCase:\t'" + lower + "'");

upper = upper.PadLeft(40);
lower = lower.PadRight(40, '#');
text = text.PadLeft(30, '*').PadRight(40, '*');

Console.WriteLine("\nPadded Left:'" + upper + "'");
Console.WriteLine("Padded Right:'" + lower + "'");
Console.WriteLine("Padded Both:'" + text + "'");

Console.WriteLine("\nTrimmmed Start:\t'" + upper.TrimStart() + "'");
Console.WriteLine("Trimmed End:\t'" + text.TrimEnd('*') + "'");

Console.ReadKey();