// 1330 두 수 비교하기

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = numArray[0];
int B = numArray[1];

if (A > B)
{
    Console.WriteLine(">");
}
else if (A < B)
{
    Console.WriteLine("<");
}
else
{
    Console.WriteLine("==");
}