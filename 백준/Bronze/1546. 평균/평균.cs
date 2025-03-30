// 1546. 평균

float N = float.Parse(Console.ReadLine());
float[] scoreList = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
float M = scoreList.Max();
float sum = 0f;
float len = scoreList.Count();

foreach (int score in scoreList)
{
    sum += score / M * 100;
}

Console.WriteLine(sum/len);