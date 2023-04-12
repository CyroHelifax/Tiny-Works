import random

def monty_hall(change_doors):
    car_door = random.randint(1, 3)
    player_choice = random.randint(1, 3)
    if player_choice == car_door:
        if change_doors:
            goat_doors = [door for door in range(1, 4) if door not in [player_choice, car_door]]
            opened_door = goat_doors[random.randint(0, 1)]
            new_choice = [door for door in range(1, 4) if door not in [player_choice, opened_door]][0]
            return new_choice == car_door
        else:
            return True
    else:
        if change_doors:
            return True
        else:
            return False

def simulation(change_doors, num_sims):
    wins = 0
    for i in range(num_sims):
        if monty_hall(change_doors):
            wins += 1
    return wins / num_sims

print("Probability of winning if switching doors:", simulation(True, 10000))
print("Probability of winning if not switching doors:", simulation(False, 10000))
