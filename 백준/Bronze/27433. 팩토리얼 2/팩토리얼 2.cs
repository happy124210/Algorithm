// 27433. 팩토리얼2

using System.Numerics;

int N = int.Parse(Console.ReadLine());
BigInteger result = 1;


for (int i = N; i > 1; i--)
{
    result *= i;
}

Console.WriteLine(result);