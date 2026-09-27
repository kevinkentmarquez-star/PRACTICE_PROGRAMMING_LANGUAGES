import math

print("--- Task 3: Rounding Showdown ---")

value = -7.8

print("ceil  ->", math.ceil(value))
print("floor ->", math.floor(value))
print("trunc ->", math.trunc(value))

# floor() always rounds down toward negative infinity (so -7.8 becomes -8), 
# while trunc() removes the decimal part without regard to direction (so -7.8 becomes -7), 
# and -8 is less than -7, the two functions disagree for negative numbers.
# Since floor() always rounds down to negative infinity, -7.8 becomes -8. 
# While trunc() eliminates the decimal portion regardless of direction (so -7.8 becomes -7), 
#For negative numbers, the two functions don't agree because # and -8 are less than -7. RoundingThing.py is displayed.