import sys
import queue
input = sys.stdin.readline

def card2(N):
    A = queue.Queue()
    for i in range(1,N+1):
        A.put(i)

    while A.qsize() != 1:
        A.get()
        temp = A.get()
        A.put(temp)

    return A.get()

N = int(input())
print(card2(N))