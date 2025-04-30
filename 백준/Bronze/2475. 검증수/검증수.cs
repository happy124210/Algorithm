//2475. 검증수

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;

foreach (int num in numArray)
{
    sum += (int)MathF.Pow(num, 2);
}

Console.Write(sum % 10);