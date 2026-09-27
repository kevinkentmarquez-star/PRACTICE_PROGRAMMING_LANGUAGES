import sys
import math
import random
import functools

print = functools.partial(print, flush = True)

def get_float(prompt):
    while True: 
        try:
            print (prompt, end = " ", flush = True)
            sys.stdout.flush()
            return float(input())
        except ValueError:
            print ("Invalid input. Please enter a number (e.g.: 3, 5)")
        except EOFError:
            print ("\nNo input received. Exiting program.")
            raise SystemExit

def safe_input(prompt):
    try:
        print (prompt, end = " ", flush = True)
        sys.stdout.flush()
        return input()
    except EOFError:
            print ("\nNo input received. Exiting program.")
            raise SystemExit

def pause():
    safe_input ("\nPress ENTER to return to the menu...")

def print_header(title):
    print ("\n" + "=" *70)
    print (f"{title}")
    print ("=" * 70)

def hyperbolic_menu():
    print_header ("HYPERBOLIC FUNCTIONS")
    print ("""1. Show the value of e
2. Compute sinh, cosh, tanh of a value
3. Compute asinh, acosh, atanh of a value (acosh needs x >= 1, atanh needs -1 < x < 1)
0. Back to main menu
""")

    choice = safe_input("Enter your choice:").strip()
    if choice == "1":
        print (f"\nmath.e = {math.e}")

    elif choice == "2":
        val = get_float("Enter a value: ")
        print (f"\nValue = {val}")
        print (f"sinh({val}) = {math.sinh(val)}")
        print (f"cosh({val}) = {math.cosh(val)}")
        print (f"tanh({val}) = {math.tanh(val)}")

    elif choice == "3":
        val = get_float("Enter a value")
        print()
        print (f"asinh({val}) = {math.asinh(val)}")
        try:
            print (f"acosh({val}) = {math.acosh(val)}")
        except ValueError:
            print ("acosh(x) needs x >= 1. Skipped.")
        try:
            print (f"atanh({val}) = {math.atanh(val)}")
        except ValueError:
            print ("atanh(x) needs -1 < x < 1. Skipped.")

    elif choice == "0":
        return
    else:
        print ("\nInvalid Choice.")

    pause()

hyperbolic_menu()