import sys
input = sys.stdin.readline

def FindNum(N, A, num):
    target = num
    left = 0 
    right = N-1

    while left<=right:
        mid = (left+right)//2
        if A[mid] == target:
            return 1
        elif A[mid]>target:
            right = mid-1
        else :
            left = mid+1
    
    return 0

N = int(input())
A = [int(x) for x in input().split()]
A.sort()
M = int(input())
B = [int(x) for x in input().split()]

for num in B:
    print(FindNum(N, A, num))
