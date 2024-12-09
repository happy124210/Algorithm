import sys
input = sys.stdin.readline

T = int(input())

def FiboCounting(N):

    F = [0] * (N+2)

    #초기값 설정
    F[0] = (1, 0)
    F[1] = (0, 1)

    if N == 0 or N == 1:
        return F[N]

    for i in range(2, N+1):
        F[i] = (F[i-1][0]+F[i-2][0], F[i-1][1]+F[i-2][1])

    return F[i]

for _ in range(T):
    N = int(input())
    result = FiboCounting(N)
    print(result[0], result[1])