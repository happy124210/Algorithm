import sys
input = sys.stdin.readline

def factorial(n):
    result = 1
    for i in range(2,n+1):
        result *= i
    return result

def BinaryCoefficient(n, k):
    nCk = factorial(n) / (factorial(n-k) * factorial(k))
    return int(nCk)

N, K = map(int, input().split())
print(BinaryCoefficient(N, K))