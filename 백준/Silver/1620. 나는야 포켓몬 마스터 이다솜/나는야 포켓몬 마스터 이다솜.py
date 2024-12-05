import sys
input = sys.stdin.readline

N, M = map(int, input().split())

def PokemonDict(N, M):
    pokedex_num = {}
    pokedex_name = {}

    for i in range(1, N+1):
        name = input().rstrip()
        #key가 num
        pokedex_num[i] = name

        #key가 name
        pokedex_name[name] = i
    
    for _ in range(M):
        search = input().rstrip()
        if search.isdigit():
            print(pokedex_num.get(int(search)))
        else:
            print(pokedex_name.get(search))

PokemonDict(N, M)