import sys
input = sys.stdin.readline

def EditDistance(X, Y):
    m, n = len(X), len(Y)
    dp = [[0] * (n+1) for _ in range(m+1)]

    for i in range(m): dp[i][0] = i #모두 삭제
    for j in range(n): dp[0][j] = j #모두 삽입

    for i in range(1, m+1):
        for j in range(1, n+1):
            if X[i-1] == Y[j-1]:
                dp[i][j] = dp[i-1][j-1]
            else:
                dp[i][j] = min(dp[i-1][j], dp[i][j-1], dp[i-1][j-1]) + 1
    
    return dp[m][n]

X = input()
Y = input()
print(EditDistance(X, Y))