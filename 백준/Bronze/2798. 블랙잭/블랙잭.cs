// 2798. 블랙잭

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = numArray[0];
int M = numArray[1];
int sum = 0;
int result = 0;

int[] cardArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < cardArray.Count(); i++)
{
    for (int j = i + 1; j < cardArray.Count(); j++)
    {
        for (int k = j + 1; k < cardArray.Count(); k++)
        {
            sum = cardArray[i] + cardArray[j] + cardArray[k];

            if (sum <= M && sum > result)
            {
                result = sum;
            }
        }
    }
}

Console.Write(result);