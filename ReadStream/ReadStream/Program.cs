Console.Title = "ReadStream";

string path = "C:\\Users\\username\\source\\repos\\ReadStream\\TopFive.csv";        // username changed for git

try
{
    // Statements.. (step 4)

    using (StreamReader reader = new StreamReader(path))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            // Statements.. (steps 5 and 6)

            if (line.IndexOf("Rank") != -1) line = line.ToUpper();
            if (line.IndexOf("Sia") != -1) line += " ft. Sean Paul";

            string[] sub = line.Split(',');
            line = String.Format("{0,-30}{1,-20}", sub[1], sub[2]);
            Console.WriteLine(line);
        }
    }
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

Console.ReadKey();