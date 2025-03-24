//11720. 숫자의 합

int N = int.Parse(Console.ReadLine());
string numArray = Console.ReadLine();
int result = 0;


for (int i = 0; i <= N-1 ; i++)
{
    result += (int)(numArray[i] - '0');
}

Console.Write(result);