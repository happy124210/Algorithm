def gcd_lcm(a, b):
    gcd = 1
    for _ in range(max(a,b)):
        for i in range(max(a,b), 1, - 1):
            if a % i == 0 and b % i == 0:
                a, b = a//i, b//i
                gcd *= i
                break

    if a == b:
        lcm = gcd * a
    else: lcm = gcd * a * b
    return gcd, lcm

a, b = map(int, input().split())
result = gcd_lcm(a, b)

for num in result:
    print(num)