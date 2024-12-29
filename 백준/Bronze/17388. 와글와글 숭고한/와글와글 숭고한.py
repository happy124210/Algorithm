S, K, H = map(int, input().split())

if S+K+H >= 100:
    print('OK')
else:
    result = min(S, K, H)
    if result == S:
        print('Soongsil')
    elif result == K:
        print('Korea')
    else:
        print('Hanyang')