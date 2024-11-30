import sys
input = sys.stdin.readline

N = int(input())

def Factorial(N):
    result = 1
    for i in range(2,N+1):
        result *= i

    return result

def Counting(N):
    A = list(str(N))
    count = 0
    for i in range(len(A)-1, -1, -1):
        if A[i] == '0':
            count += 1
        else:
            return count


print(Counting(Factorial(N)))