Console.Title = "ForLoop";

for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Loop iteration: " + i);
    // Nested loop to be inserted here (Step 4)
    for (int j = 1; j < 4; j++)
    {
        Console.WriteLine("\tInner Loop Iteration: " + j);
    }
}
Console.ReadKey();
