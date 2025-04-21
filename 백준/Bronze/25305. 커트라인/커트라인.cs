// 25305. 커트라인

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] scoreArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int N = numArray[0];
int k = numArray[1];

Array.Sort(scoreArray);
Console.Write(scoreArray[^k]);