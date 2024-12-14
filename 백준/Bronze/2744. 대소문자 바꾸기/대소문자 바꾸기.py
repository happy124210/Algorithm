A = input()

for letter in A:
   if letter.isupper():
      print(letter.lower(), end='')
   else:
      print(letter.upper(), end='')