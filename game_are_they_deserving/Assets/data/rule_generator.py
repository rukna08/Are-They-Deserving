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
    print("RULES:")
    print(rules)
    print("\n")

    print("ALLOWED:")
    print(allowed)
    print("\n")
    
    print("NOT ALLOWED:")
    print(not_allowed)
    print("\n")