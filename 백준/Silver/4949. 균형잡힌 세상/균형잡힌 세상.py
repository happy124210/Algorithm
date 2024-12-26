import sys
from collections import deque

input = sys.stdin.readline

def Check(A):
    queue = deque()
    for word in A:
        if word == '(' or word == '[':
            queue.append(word)
        elif word == ')':
            if len(queue) == 0:
                print('no')
                return
            popCheck = queue.pop()
            if popCheck != '(':
                print('no')
                return
        elif word == ']':
            if len(queue) == 0:
                print('no')
                return
            popCheck = queue.pop()
            if popCheck != '[':
                print('no')
                return
        else:
            continue

    if len(queue) == 0:
        print('yes')
    else:
        print('no')

while True:
    A = list(input().rstrip())
    if A[0] == '.':
        break
    else:
        Check(A)