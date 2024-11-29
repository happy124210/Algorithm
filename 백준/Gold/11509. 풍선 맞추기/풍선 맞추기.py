import sys
input = sys.stdin.readline

N = int(input())
Balloons = [int(x) for x in input().split()]

def Arrow(N, Balloons):
    arrows = {}
    arrownum = 0

    for height in Balloons:
        if height in arrows and arrows[height] > 0:
            arrows[height] -= 1
        else:
            arrownum += 1
        
        if height - 1 > 0:
            arrows[height - 1] = arrows.get(height - 1, 0) + 1

    return arrownum

print(Arrow(N, Balloons))