// 13227. 큰 수 곱셈

using System.Numerics;

BigInteger[] numArray = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);

BigInteger A = numArray[0];
BigInteger B = numArray[1];

Console.WriteLine(A * B);