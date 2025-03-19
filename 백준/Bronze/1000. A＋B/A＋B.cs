int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int result = numArray.Sum();
Console.WriteLine(result);