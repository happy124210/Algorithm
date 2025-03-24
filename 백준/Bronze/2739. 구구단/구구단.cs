int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= 9; i++)
{
    int result = N * i;
    Console.WriteLine("{0} * {1} = {2}", N, i, result);
}