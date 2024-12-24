A, B = map(str, input().split())
A = int(A, 2)
B = int(B, 2)

result = bin(A+B)
print(result[2:])