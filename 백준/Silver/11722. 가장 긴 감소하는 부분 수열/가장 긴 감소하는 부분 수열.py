import sys
input = sys.stdin.readline

def LIS(N, A):
    dp = [1] * N

    for i in range(1, N):
        for j in range(i):
            if A[j] > A[i]:
                dp[i] = max(dp[i], dp[j] + 1)

    return max(dp)

N = int(input())
A = [int(x) for x in input().split()]

print(LIS(N, A))