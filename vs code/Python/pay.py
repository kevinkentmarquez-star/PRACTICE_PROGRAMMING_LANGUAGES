total = 0
numbers_entered = []

while True:
    user_input = input("Enter a number (or type 'stop' to end): ")

    if user_input.lower() == "stop":
        break

    try:
        number = int(user_input)

        if number == 0:
            total = 0
            numbers_entered.append({"value": number, "type": "zero", "action": "reset"})
            print(f"{number} is ZERO → Total reset to 0. Running total: {total}")
        elif number % 2 == 0:
            total += number
            numbers_entered.append({"value": number, "type": "even", "action": "added"})
            print(f"{number} is EVEN → Added. Running total: {total}")
        else:
            total -= number
            numbers_entered.append({"value": number, "type": "odd", "action": "subtracted"})
            print(f"{number} is ODD  → Subtracted. Running total: {total}")

    except ValueError:
        print("Invalid input. Please enter a number or 'stop'.")

print("\nYou typed 'stop'. The program is ending!")
print("\n--- Summary of all numbers you entered ---")

for entry in numbers_entered:
    if entry["type"] == "zero":
        print(f"  {input['value']} → Zero (total was reset)")
    elif entry["type"] == "even":
        print(f"  {input['value']} → Even (was added)")
    else: # odd
        print(f"  {input['value']} → Odd (was subtracted)")

print(f"\nFinal Total: {total}")