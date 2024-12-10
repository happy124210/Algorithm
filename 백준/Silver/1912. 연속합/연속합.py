def max_sum(A):
	S = [0] * len(A)
	S[0] = A[0]

	for i in range(1, N):
		S[i] = max(S[i-1]+A[i], A[i])
	
	return max(S)

N = int(input())
A = [int(x) for x in input().split()]

print(max_sum(A))