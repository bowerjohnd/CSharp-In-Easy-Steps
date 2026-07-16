Console.Title = "Joined";

string[] a = new string[3] { "Alpha", "Bravo", "Charlie" };

string s = String.Concat(a[0], a[1]);
Console.WriteLine("Concatenated:\t" + s);

s = String.Join(" ", a[0], a[1]);
Console.WriteLine("Joined:\t\t" + s);

s = String.Join("<br>", a);
Console.WriteLine("\nHTML:\t" + s + "\n");

int num = String.Compare(a[0], a[1]);
Console.WriteLine(a[0] + " v " + a[1] + ":\t" + num);

num = String.Compare(a[2], a[1]);
Console.WriteLine(a[2] + " v " + a[1] + ":\t" + num);

num = a[1].CompareTo(a[1]);
Console.WriteLine(a[1] + " v " + a[1] + ":\t" + num + "\n");

bool flag = (a[0] == a[1]);
Console.WriteLine(a[0] + " == " + a[1] + ":\t\t\t" + flag);             // False
flag = a[2].Equals(a[2]);
Console.WriteLine(a[2] + " == " + a[2] + ":\t\t" + flag);               // True

// Is it comparing text to text for both? or text to object address for Equals?

flag = (a[0] == "Alpha");
Console.WriteLine("(" + a[0] + ") a[0] == \"Alpha\":\t" + flag);        // True
flag = a[1].Equals("Bravo");
Console.WriteLine("(" + a[1] + ") a[1] Equals(\"Bravo\"):\t" + flag);   // True

string[] b = new string[3] { "Alpha", "Bravo", "Charlie" };

flag = (a[0] == b[0]);
Console.WriteLine("a[0] == b[0]: \t\t\t" + flag);                         // True
flag = a[1].Equals(b[1]);
Console.WriteLine("a[1].Equals(b[1]): \t\t" + flag);                      // True

// It is comparing text for both.

Console.ReadKey();
