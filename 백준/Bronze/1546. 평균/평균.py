N = int(input())
scores = [int(x) for x in input().split()]

M = max(scores)
for i in range(N):
    scores[i] = (scores[i] / M) * 100

print(sum(scores)/N)