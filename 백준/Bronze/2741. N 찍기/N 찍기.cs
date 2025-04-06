// 2741. N찍기

int N = int.Parse(Console.ReadLine());

int[] numList = new int[N];

for (int i = 0; i < N; i++)
{
    numList[i] = i+1;
}

Console.Write(string.Join("\n", numList));