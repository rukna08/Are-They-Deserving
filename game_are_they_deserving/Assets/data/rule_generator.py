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


if debug == 1:
    print("RULES:")
    print(rules)
    print("\n")

    print("ALLOWED:")
    print(allowed)
    print("\n")
    
    print("NOT ALLOWED:")
    print(not_allowed)
    print("\n")