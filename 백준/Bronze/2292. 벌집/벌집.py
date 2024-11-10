def Beehouse(N):
    num = (N-2)//6
    for i in range(1, 1000000000):
        numRange = i*(i-1)/2
        if num < numRange:
            print(i)
            break

N = int(input())
Beehouse(N)