// 2231. 분해합

int N = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i < N; i++)
{
    int sum = i;
    int temp = i;

    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }

    if (sum == N)
    {
        result = i;
        break;
    } 
}

Console.WriteLine(result);