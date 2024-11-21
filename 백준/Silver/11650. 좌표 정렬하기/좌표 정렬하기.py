import sys
input = sys.stdin.readline

N = int(input())
A = []

for _ in range(N):
    x, y = map(int, input().split())
    A.append((x, y))

A.sort(key = lambda x: (x[0], x[1]))

for axis in A:
    print(axis[0], axis[1])