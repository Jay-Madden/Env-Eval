import random
import string

test_cases = []
for _ in range(100): 
    test_cases.append(f'{random.randint(1,20)}:{random.randint(1,20)}:{random.choice(string.ascii_uppercase)}\n')

with open('Part2Input.txt', 'w+') as f:
    f.writelines(test_cases)
