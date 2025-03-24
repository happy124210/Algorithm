//2562. 최댓값

int[] numArray = new int[9];

for (int i = 0; i < 9; i++)
{
    numArray[i] = int.Parse(Console.ReadLine());
}

int result = numArray.Max();
int index = Array.FindIndex(numArray, x => x == result);

Console.WriteLine(result);
Console.WriteLine(index + 1);