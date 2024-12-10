import sys
input = sys.stdin.readline

def LCS(X, Y):
    n = len(X)
    m = len(Y)

    dp = [[0 for _ in range(m+1)] for i in range(n+1)]

    for j in range(0, m+1): dp[0][j] = 0
    for i in range(0, n+1): dp[i][0] = 0

    for i in range(1, n+1):
        for j in range(1, m+1):
            if X[i-1] == Y[j-1]:
                dp[i][j] = dp[i-1][j-1] + 1
            else:
                dp[i][j] = max(dp[i-1][j], dp[i][j-1])

    return dp[n][m]

X = input().strip()
Y = input().strip()

print(LCS(X, Y))