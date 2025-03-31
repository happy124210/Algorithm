// 15963. CASIO

using System.Numerics;

BigInteger[] numArray = Array.ConvertAll(Console.ReadLine().Split(), BigInteger.Parse);

if (numArray[0] == numArray[1])
{
    Console.Write("1");
}
else
{
    Console.Write("0");
}