var nums = new List<int> { 1, 2, 3 };
foreach (var num in nums)
    Console.Write(num);
Console.WriteLine();

Console.WriteLine("\nHello, check these numbers out!");

static double CalculateAverage(int[] values) =>
    values.Average();

Console.WriteLine("\nAverage is: " + CalculateAverage([.. nums]));
