// 30802. 웰컴 키트

int N = int.Parse(Console.ReadLine());
double[] sizeNum = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
double T = numArray[0];
int P = numArray[1];

int Tsum = 0;

// T
foreach(double n in sizeNum)
{
    Tsum += (int)Math.Ceiling(n / T);
}

Console.WriteLine(Tsum);
Console.WriteLine($"{N/P} {N%P}");