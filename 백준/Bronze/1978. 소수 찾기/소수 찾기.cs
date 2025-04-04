// 1978. 소수 찾기

int N = int.Parse(Console.ReadLine());
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = 0;

// 소수 검사
for (int i = 0; i < N; i++)
{
    // 시작 조건
    if (numbers[i] == 1)
    {
        continue;
    }

    // 2 예외처리
    else if (numbers[i] == 2)
    {
        result += 1;
        continue;
    }

    else if (numbers[i] % 2 == 0)
    {
        continue;
    }

    else
    {
        bool flag = true;

        // 개수 세기
        for (int j = 3; j*j <= numbers[i] ;  j += 2)
        {   
            if (numbers[i] % j == 0)
            {
                flag = false;
                break;
            }
        }

        if (flag)
        {
            result += 1;
        }
    }
    
}

Console.WriteLine(result);