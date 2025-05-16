import os
import random

debug = 1

with open("base.txt", 'r') as base_file:
    rules = [rules.strip() for rules in base_file]

allowed = []
not_allowed = []

for i in range(len(rules)):
    random_dice_roll = random.randint(0, 1)
    if random_dice_roll == 0:
        allowed.append(rules[i])
    else:
        not_allowed.append(rules[i])

allowed_values = []
not_allowed_values = []

for i in range(len(allowed)):
    allowed_values.append(random.randint(10, 100))
    allowed[i] += ":" + str(allowed_values[i]) + ";"
for i in range(len(not_allowed)):
    not_allowed_values.append(random.randint(10, 100))
    not_allowed[i] += ":" + str(not_allowed_values[i]) + ";"


if debug == 1:
    os.system("cls")

    print("RULES:")
    for i in range(len(rules)):
        print(rules[i])
    print("\n")

    print("ALLOWED:")
    for i in range(len(allowed)):
        print(allowed[i])
    print("\n")
    
    print("NOT ALLOWED:")
    for i in range(len(not_allowed)):
        print(not_allowed[i])
    print("\n")

with open("allowed.txt", "w") as allowed_file:
    for line in allowed:
        allowed_file.write(f"{line}\n")
with open("not_allowed.txt", "w") as not_allowed_file:
    for line in not_allowed:
        not_allowed_file.write(f"{line}\n")