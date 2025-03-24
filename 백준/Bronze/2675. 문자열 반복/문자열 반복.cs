//2675. 문자열 반복

int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string[] input = Console.ReadLine().Split();
    int R = int.Parse(input[0]);
    string S = input[1];

    foreach (var c in S)
    {
        Console.Write(new string(c, R));
    }
    
    Console.WriteLine();

}