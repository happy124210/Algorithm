N = int(input())
voteSum = 0

for _ in range(N):
    vote = int(input())
    voteSum += vote

if voteSum > N//2:
    print("Junhee is cute!")
else:
    print("Junhee is not cute!")