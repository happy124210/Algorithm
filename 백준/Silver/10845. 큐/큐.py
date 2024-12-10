import sys
input = sys.stdin.readline

from collections import deque

def Queue():

    queue = deque()

    def Command(command):

        if command[0] == 'push':
            queue.append(int(command[1]))
            return

        elif command[0] == 'pop':
            if queue:
                return queue.popleft()
            else:
                return -1

        elif command[0] == 'size':
            return len(queue)

        elif command[0] == 'empty':
            if len(queue) != 0:
                return 0
            else:
                return 1
        elif command[0] == 'front':
            if len(queue) > 0:
                return(queue[0])
            else:
                return -1
        elif command[0] == 'back':
            if len(queue) > 0:
                return(queue[-1])
            else:
                return -1
    
    return Command


N = int(input())
commands = [input().strip().split() for _ in range(N)]

queue = Queue()

for command in commands:
    result = queue(command)

    if result is not None:
        print(result)