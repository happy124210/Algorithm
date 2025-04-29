//10871. X보다 작은 수

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = numArray[0];
int X = numArray[1];

int[] intArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

foreach (int num in intArray)
{
    if (num < X) Console.Write($"{num} ");
}