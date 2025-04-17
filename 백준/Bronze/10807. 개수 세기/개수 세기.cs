// 10807. 개수 세기


int N = int.Parse(Console.ReadLine());
int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int v = int.Parse(Console.ReadLine());
int count = 0;

foreach (int num in numArray)
{
    if (num == v) count += 1;
}

Console.Write(count);