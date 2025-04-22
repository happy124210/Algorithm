// 25191. 치킨댄스를 추는 곰곰이를 본 임스

int N = int.Parse(Console.ReadLine());
int[] numArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int A = numArray[0];
int B = numArray[1];

int result = A / 2 + B;
Console.WriteLine(Math.Min(result, N));