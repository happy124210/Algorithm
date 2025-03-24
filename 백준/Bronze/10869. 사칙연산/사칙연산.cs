int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = numArray[0];
int B = numArray[1];

Console.WriteLine(A+B);
Console.WriteLine(A-B);
Console.WriteLine(A*B);
Console.WriteLine(A/B);
Console.WriteLine(A%B);