import sys
input = sys.stdin.readline

N, M = map(int, input().split())
nums = []

for i in range(1, N+1):
    nums.append(i)

for _ in range(M):
    a, b = map(int, input().split())
    temp = nums[b-1]
    nums[b-1] = nums[a-1]
    nums[a-1] = temp

for num in nums:
    print(num, end=' ')