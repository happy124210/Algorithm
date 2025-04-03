// 9086. 문자열

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string word = Console.ReadLine();
    Console.WriteLine($"{word[0]}{word[word.Length-1]}");
}