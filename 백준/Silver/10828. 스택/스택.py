import sys
input = sys.stdin.readline

def Stack():

    stack = []

    def Command(command):

        if command[0] == 'push':
            stack.append(int(command[1]))
            return

        elif command[0] == 'pop':
            if stack:
                return stack.pop()
            else:
                return -1

        elif command[0] == 'size':
            return len(stack)

        elif command[0] == 'empty':
            if len(stack) != 0:
                return 0
            else:
                return 1
        elif command[0] == 'top':
            if len(stack) > 0:
                return(stack[-1])
            else:
                return -1
    
    return Command


N = int(input())
commands = [input().strip().split() for _ in range(N)]

stack = Stack()

for command in commands:
    result = stack(command)

    if result is not None:
        print(result)