import sys
from collections import deque
input = sys.stdin.readline

def Josephus(N, K):
    A = deque()
    B = []
    for i in range(1, N+1):
        A.append(i)
    
    #K번째 수 저장
    count = 0

    while len(A) != 0:
        temp = A.popleft()
        count += 1
        if count == K:
            B.append(temp)
            count = 0
        else: 
            A.append(temp)

    return B

N, K = map(int, input().split())
result = Josephus(N, K)
print('<', end='')
for num in result[:N-1]:
    print(num, end=', ')
print(result[-1], end='')
print('>')