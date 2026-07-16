Console.Title = "WriteText";

//Edit the line below to include your own user name.
string path = "C:\\Users\\username\\source\\repos\\WriteText\\poem.txt";        // username changed for git

string poem = "\r\n\tI never saw a man who looked";
poem += "\r\n\tWith such a wistful eye";
poem += "\r\n\tUpon that little tent of blue";
poem += "\r\n\tWhich prisoners call the sky";

if (File.Exists(path))
{
    Console.WriteLine("File Already Exists: " + path);
}
else
{
    // Statements to be inserted here (step 4)
    
    try
    {
        File.WriteAllText(path, poem);
        Console.WriteLine("File Written: " + path);
    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }
}

Console.ReadKey();