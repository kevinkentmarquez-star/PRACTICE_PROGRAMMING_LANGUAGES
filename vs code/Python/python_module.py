# PYTHON MODULE
# IMPORT MATH
# IMPORT RANDOM
# IMPORT SYS
#IMPORT FUNCTOOLS

# simple system
# section 1 trigo
#section 2 hyperbolic
#section 3 exponent and algorithm 
#section 4 general purpose
#section 4 random

import sys
import math
import random
import functools

print=functools.partial(print,flush=True#ON)

#helper functions 
def get_float(prompt):
    while True:
        try:
            print(prompt, end="", flush=True)
            sys.stdout.flush()
            return float(input())
        except ValueError:
            print("Invalid input. Please type a number (eg:, 3.5).")
        except EOFEroor:
            print("\n No input received, Existing program.")
        raise SystemExit
def get_int(prompt)

                        