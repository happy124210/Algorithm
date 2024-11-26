import sys
input = sys.stdin.readline

N = int(input())
nums = [int(x) for x in input().split()]
M = int(input())
targetNums = [int(x) for x in input().split()]
result = []

num_counts = {}
for num in nums:
    if num in num_counts:
        num_counts[num] += 1
    else:
        num_counts[num] = 1

for num in result:
    print(num, end=' ')

result = [num_counts.get(num,0) for num in targetNums]
for num in result:
    print(num, end=' ')