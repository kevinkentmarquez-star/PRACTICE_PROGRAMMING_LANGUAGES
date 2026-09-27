# import math 
#print(math.sin(math.pi/2))
# output is 1.0 

#import math


def sin(x):
    if 2 * x == pi:
        return 0.99999999
    else:
        return None


pi = 3.14

print(sin(pi/2))
print(math.sin(math.pi/2))

# out put is 0.99999999
# 1.0 

from math import sin, pi

print(sin(pi/2))
#math modules
from math import sin, pi

print(sin(pi / 2))

pi = 3.14


def sin(x):
    if 2 * x == pi:
        return 0.99999999
    else:
        return None


print(sin(pi / 2))
#ine 1: carry out the selective import;
#line 3: make use of the imported entities and get the expected result (1.0)
#lines 5 through 12: redefine the meaning of pi and sin - in effect, they supersede the original (imported) definitions within the code's namespace;
#line 15: get 0.99999999, which confirms our conclusions.

pi = 3.14


def sin(x):
    if 2 * x == pi:
        return 0.99999999
    else:
        return None


print(sin(pi / 2))

from math import sin, pi

print(sin(pi / 2))

lines 1 through 8: define our own pi and sin;
line 11: make use of them (0.99999999 appears on the screen)
line 13: carry out the import - the imported symbols supersede their previous definitions within the namespace;
line 15: get 1.0 as a result.

importing a module:
from module import 
#import all entities from the dedicated module

The as keyword

#  Aliasing causes the module to be identified under a different name than the original. This may shorten the qualified names, too.
import module as alias

#aliasing
# if you need to change name math replace it "m"
import math as m
    
print(m.sin(m.pi/2))
# original module name becomes inaccessible

#from module import name 
from module import name as alias

#phrase name as alias can be repeated - use commas to separate the multiplied phrases, like this:
from module import n as a, m as b, o as c

ceil = math.ceil(num )
# The ceil() function returns the smallest integer not less than sum 
math.ceil(1.03) gives 2.0
sqrt = math.sprt(num) returns the square root of num
math.sprt(81.0) gives 9.0
exp = math.exp(arg) 
returns the natural logarithm e raised to the arg power. 
math.exp(2.0) gives the value e squared 2

fabs = math.fabs(num) 
returns the absolute value of num 
math.fabs(-1.0) gives 1.0

floor = math.floor(num)
returns the largest integer not greater than num 
math.floor(1.03) giv4es 1.0
math.floor(-1.03) gives -2.0 

# dir(module)
import math
  
for name in dir(math):
  print(name, end="∖t")
# selected function from the math modules
#trigonemetry 
sin(x) # the sine of x
cos(x) # the cosing of x
tan(x) # the tangent of x be careful with tan() - not all arguments are accepted).
# inversed versions
asin(x) # the arcsine of x
acos(x) # the arccosine of x
atan(x) # the arctangent of x
# these functions take oe argument (mind the domains) - return a measure of an angle in radians
# pi - a constant with a value is an approximation of 3.14 in math
# radians(x) a function that converts x from the degress to radians
# degrees(x) acting in the order other direction  (from radians to degrees)

from math import pi, radians, degrees, sin, cos, tan, asin

ad = 90
ar = radians(ad)
ad = degrees(ar)

print(ad == 90.)
print(ar == pi / 2.)
print(sin(ar) / cos(ar) == tan(ar))
print(asin(sin(ar)) == ar)
# hyperbolic analog
sinh(x) hyperbolic sine 
cosh(x) hyperbolic cosine
tanh(x) hyperbolic tangent
asinh(x) hyperbolic arcsine
acosh hyperbolic arccosine
atanh(x) hyperbolic arctangent

#exponentiation;
# e → a constant with a value that is an approximation of Euler's number (e)  equal to 2.71828
# (Inverse of: natural logarithm (log)

#exp(x) → finding the value of ex # Natural Exponential Function
"What power do I raise e to, to get x?"
import math
math.exp(2)   # e² ≈ 7.389
math.exp(1)   # e¹ ≈ 2.71828

#log(x) → the natural logarithm of x (Natural Logarithm) Inverse of: exp(x) → log(exp(x)) = x
What power do I raise b to, to get x?"
Formula: \(\log_b(x) = \frac{\ln(x)}{\ln(b)}\)
math.log(10)      # ln(10) ≈ 2.3026
math.log(math.e)  # ln(e) = 1.0

#log(x, b) → the logarithm of x to base b 
What power do I raise b to, to get x?"
Formula: \(\log_b(x) = \frac{\ln(x)}{\ln(b)}\)
math.log(16, 4)   # log₄(16) = 2 → 4² = 16
math.log(100,10)  # log₁₀(100) = 2

#log10(x) → the decimal logarithm of x (more precise than log(x, 10))
Specialized, more precise than log(x, 10)
Tells you the order of magnitude (how many digits a number roughly has)
math.log10(1000)   # log₁₀(1000) = 3
math.log10(1)      # = 0

#log2(x) → the binary logarithm of x (more precise than log(x, 2))
Specialized, more precise than log(x, 2)
Common in computing: "how many bits do I need to store this number?"

# summary 
Function	Math Notation	Base	Best For
exp(x)	ex	e ≈ 2.718	Growth, continuous processes
log(x)	ln(x)	e	Calculus, formulas, exponentials
log(x, b)	logb​(x)	Any base b	General-purpose logs
log10(x)	log10​(x)	10	Decimal scale, magnitude
log2(x)	log2​(x)	2	Bits, algorithms, computing

#pow() function: 
pow(x, y) → finding the value of xy (mind the domains) This is a built-in function, and doesn't have to be imported.
from math import e, exp, log

print(pow(e, 1) == exp(log(e)))
print(pow(2, 2) == exp(2 * log(2)))
print(log(e, e) == exp(0))
# output is false, True , True
# The last group consists of some general-purpose functions like:
ceil(x) → the ceiling of x (the smallest integer greater than or equal to x)
floor(x) → the floor of x (the largest integer less than or equal to x)
trunc(x) → the value of x truncated to an integer (be careful - it's not an equivalent either of ceil or floor)
factorial(x) → returns x! (x has to be an integral and not a negative)
hypot(x, y) → returns the length of the hypotenuse of a right-angle triangle with the leg lengths equal to x and y (the same as sqrt(pow(x, 2) + pow(y, 2)) but more precise)

# fundamental differences between ceil(), floor() and trunc(). 
from math import ceil, floor, trunc

x = 1.4
y = 2.6

print(floor(x), floor(y))
print(floor(-x), floor(-y))
print(ceil(x), ceil(y))
print(ceil(-x), ceil(-y))
print(trunc(x), trunc(y))
print(trunc(-x), trunc(-y))

# output is  
1 2
-2 -3
2 3
-1 -2
1 2
-1 -2

# random  pseudorandom numbers.

# selectef functions from the random module
# the random function 
random() (not to be confused with the module's name) produces a float number x coming from the range (0.0, 1.0) - in other words: (0.0 <= x < 1.0).
from random import random

for i in range(5):
    print(random())

0.9535768927411208
0.5312710096244534
0.8737691983477731
0.5896799172452125
0.02116716297022092

seed() function is able to directly set the generator's seed.
# two variants 
seed() - sets the seed with the current time;
seed(int_value) - sets the seed with the integer value int_value.

from random import random, seed

seed(0)

for i in range(5):
    print(random())

0.844421851525
0.75795440294
0.420571580831
0.258916750293
0.511274721369

# The randrange and randint functions
#   if you want integer random values, one of the following functions would fit better:
randrange(end)
randrange(beg, end)
randrange(beg, end, step)
randint(left, right)

# The first three invocations will generate an integer taken (pseudorandomly) from the range (respectively):
range(end)
range(beg, end)
range(beg, end, step)

implicit right-sided exclusion! t generates the integer value i, which falls in the range [left, right] (no exclusion on the right side).
from random import randrange, randint

print(randrange(1), end=' ')
print(randrange(0, 1), end=' ')
print(randrange(0, 1, 1), end=' ')
print(randint(0, 1))

 # the output is 0 0 0 1

from random import randint

for i in range(10):
    print(randint(1, 10), end=',')

# the output is 7,5,5,8,2,9,6,9,1,2,

the choice and sample functions 
It's a function named in a very suggestive way - choice:

choice(sequence)
sample(sequence, elements_to_choose)
The first variant chooses a "random" element from the input sequence and returns it.
scond one builds a list (a sample) consisting of the elements_to_choose element drawn from the input seed 
Note: the elements_to_choose must not be greater than the length of the input sequence.

from random import choice, sample

my_list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

print(choice(my_list))
print(sample(my_list, 5))
print(sample(my_list, 10))

4
[10, 9, 6, 2, 7]
[2, 4, 7, 8, 5, 6, 3, 9, 1, 10]

# the platform function:
# module lets you access the underlying platform's data, i.e., hardware, operating system, and interpreter version information.:
# named platform, too. It just returns a string describing the environment;

platform(aliased = False, terse = False)
aliased → when set to True (or any non-zero value) it may cause the function to present the alternative underlying layer names instead of the common ones;
terse → when set to True (or any non-zero value) it may convince the function to present a briefer form of the result (if possible)

from platform import platform
 
print(platform())
print(platform(1))
print(platform(0, 1))

Windows-11-10.0.26200-SP0
Windows-11-10.0.26200-SP0
Windows-11
 