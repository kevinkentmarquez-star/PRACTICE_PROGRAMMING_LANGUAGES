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