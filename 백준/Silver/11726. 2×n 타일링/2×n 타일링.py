import sys
input = sys.stdin.readline


def Tiling(N):

    A = [0] * (N+1)
    
    if N == 1 or N == 2:
        return N
    
    A[1] = 1
    A[2] = 2

    for i in range(3, N+1):
        A[i] = A[i-1] + A[i-2]

    return (A[N])%10007

N = int(input())
print(Tiling(N))