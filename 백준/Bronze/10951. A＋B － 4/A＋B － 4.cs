while(true)
{
    var input = Console.ReadLine();

    if (input == null)
        break;

    int[] numArray = Array.ConvertAll(input.Split(), int.Parse);
    int A = numArray[0];
    int B = numArray[1];

    Console.WriteLine(A + B);
}