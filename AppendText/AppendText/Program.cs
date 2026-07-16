Console.Title = "AppendText";

string path = "C:\\Users\\username\\source\\repos\\AppendText\\oscar.txt";      // username changed for git

string[] poem = new string[]
{
    "\tIn Debtors' Yard the stones are hard",
    "\tAnd the dripping wall is high"
};

string attrib = "\r\n\tThe Ballad of Reading Gaol";
attrib += "(Oscar Wilde 1898)";

if (File.Exists(path))
{
    // Statements.. (step 4)

    File.AppendAllText(path, attrib);
    Console.WriteLine("Appended To File: " + path);
}
else
{
    // Statements.. (Step 5)

    try
    {
        File.WriteAllLines(path, poem);
        Console.WriteLine("File Written: " + path);
    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }
}

Console.ReadKey();