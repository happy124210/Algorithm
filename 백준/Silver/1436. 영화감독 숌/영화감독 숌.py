def devilnum(N):
    count = 0
    num = 666
    while True:
        num = str(num)
        if num.find('666') != -1:
            count += 1
        if count == N:
            return num
        num = int(num)
        num += 1

N = int(input())
print(devilnum(N))