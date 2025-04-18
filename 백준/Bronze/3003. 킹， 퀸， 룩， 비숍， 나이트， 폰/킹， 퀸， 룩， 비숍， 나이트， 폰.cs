// 3003. 킹, 퀸, 룩, 비숍, 나이트, 폰

int[] chess = { 1, 1, 2, 2, 2, 8 };
int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int index = 0;

foreach (int num in numArray)
{
    Console.Write($"{chess[index] - num} ");
    index++;
}