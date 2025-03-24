//10818. 최소, 최대

int N = int.Parse(Console.ReadLine());
int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int minNum = numArray.Min();
int maxNum = numArray.Max();

Console.WriteLine($"{minNum} {maxNum}");