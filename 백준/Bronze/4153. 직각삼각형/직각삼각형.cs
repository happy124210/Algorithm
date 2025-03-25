//4153. 직각삼각형

using System.Data;

while (true)
{
    string input = Console.ReadLine();

    // endpoint
    if (input == "0 0 0")
        break;

    // numarray
    int[] numArray = Array.ConvertAll(input.Split(), int.Parse);
    Array.Sort(numArray);
    double a = numArray[0];
    double b = numArray[1];
    double c = numArray[2];

    // right triangle
    if ( Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) )
        Console.WriteLine("right");
    else
        Console.WriteLine("wrong");
    
}