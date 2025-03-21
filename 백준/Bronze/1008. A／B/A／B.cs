// 1008. A/B

int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

double A = numArray[0];
double B = numArray[1];
double result = A / B;

Console.WriteLine(result);