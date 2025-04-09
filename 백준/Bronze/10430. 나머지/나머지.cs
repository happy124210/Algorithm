// 10430. 나머지

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = numArray[0];
int B = numArray[1];
int C = numArray[2];

Console.WriteLine((A + B) % C);
Console.WriteLine(((A % C) + (B % C)) % C);
Console.WriteLine(A * B % C);
Console.WriteLine(A % C * B % C % C);