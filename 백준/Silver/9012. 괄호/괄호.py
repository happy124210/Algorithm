import sys
from collections import deque

N = int(input())

def braket(string):
    A = deque()

    if string[0] != '(':
        return("NO")

    for str in string:
        if str == '(':
            A.append(str)
        elif str == ')':
            if len(A) > 0:
                A.pop()
            else:
                return('NO')
            
    if len(A) != 0:
        return('NO')
    else:
        return('YES')
    
for _ in range(N):
    string = list(input())
    print(braket(string))