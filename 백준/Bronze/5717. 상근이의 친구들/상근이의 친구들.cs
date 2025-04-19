// 5717. 상근이의 친구들

while (true)
{
    int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int result = numArray.Sum();
    if (result == 0) return;
    Console.WriteLine(result);
}
