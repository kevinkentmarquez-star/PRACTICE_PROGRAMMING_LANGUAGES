total = 0
inputs = []

while True:
    user_input = input("Enter a number (or 'stop' to quit): ") # Corrected to use input() function
    if user_input.lower() == "stop":
        print("\nYou typed 'stop'. The program is ending!")
        break

    try:
        number = int(user_input)
        inputs.append(number)
        if number == 0:
            total = 0
            print("You entered 0 — total has been RESET to 0.\n")
        elif number % 2 == 0:
            total += number
            print(f"{number} is EVEN → Added. Running total:{total}\n")
        else:
            total -= number
            print(f"{number} is ODD → Subtracted. Running total: {total}\n")
    except ValueError:
        print("That's not a valid number. Please try again.\n")

print("\n--- Summary of all numbers you entered ---")

if len(inputs) == 0:
    print("You didn't enter any numbers.")
else:
    for num in inputs:
        if num == 0:
            print(f" {num} → Reset the total")
        elif num % 2 == 0:
            print(f" {num} → Even (was added)")
        else: # Added an else block for odd numbers in the summary
            print(f" {num} → Odd (was subtracted)")

print(f"\nFinal Total: {total}")
print("Thanks for using the program!")

#2nd 
my_list = []

for i in range(1, 10):
    my_list.append(i)

print("Original list:", my_list)
print("Length of list:", len(my_list))

y = 1
x = 0
while x < len(my_list):
    if my_list.count(my_list[x]) > 1:
        del my_list[x]
    else:
        y = y + 1
        x += 1

print("\nThe list with unique elements only.")
print(my_list)

#3rd

class Toggle:
   def __init__(self):
      self.active = False
   
   def switch(self):
      self.active = not self.active
      if self.active:
         print("Status: ACTIVE")
      else:
         print("Status: INACTIVE")

t = Toggle()
t.switch()
t.switch()
t.switch()
t.switch()


#4th

class TimesTable:
    def generate(self):
        number = int(input("Enter a number: "))
        limit = int(input("Enter the limit: "))

        for i in range(1, limit + 1):
            print(str(number) + " x " + str(i) + " = " + str(number *i))

tt = TimesTable()
tt.generate()

#5th

class GradeBook:
    def get_grade(self):
        score = int(input("Enter your score: "))
        if score >= 90:
            print("Your grade is: A")
        elif score >= 80:
            print("Your grade is: B")
        elif score >= 70:
            print("Your grade is: C")
        elif score >= 60:
            print("Your grade is: D")
        else:
            print("Your grade is: F")

gb = GradeBook()
gb.get_grade()

#6th

class Repeater:
    def repeat(self):
        word = input("Enter a word: ")
        count = int(input("How many times? "))
 
        for i in range(count):
            print(word)

rep = Repeater()
rep.repeat()

#7th

class MindReader:
   def play(self):
      secret = 42
      found = False
      while not found:
        guess = int(input("Guess the number: "))
        if guess < secret:
          print("Too low! Try higher.")
        elif guess > secret:
          print("Too high! Try lower.")
        else:
            found = True
            print("Amazing! You read my mind!")
      
mr = MindReader()
mr.play()

#8th

class WeatherCheck:
    def check_temp(self):
        temp = int(input("Enter the temperature in Celsius: "))
        if temp <= 0:
            print("It is freezing! Wear a coat.")
        else:
            print("The weather is fine.")

w = WeatherCheck()
w.check_temp()

#9th

class Profile:
    def introduce(self):
        name = input("What is your name? ")
        age = input("How old are you? ")
        color = input("What is your favorite color? ")
        print("Hi! My name is " + name + ", I am " + age + " years old, and I love the color" + color + ".")

p = Profile()
p.introduce()

reviewer = """
( “ “, ‘ ‘) - Single and Double Quotation called a string to
call out the variable.
( +,-,*,/) – Mathematical/ Arithmetic Operation use for
any mathematical problem to your code.
( + ) Sum – Used to add a two whole number.
(-) Difference – Used to subtract two whole number.
( * ) Product – Used to multiply two whole number.
( / ) Quotient – Used to divide two whole number.
( =
, += , - = ,/ =
,
* = ) – Assignment Operation use to
store and update variables values.
( { }, + ) – Curly Bracket and Plus Sign is use for adding
a string and variable.
( [ ] ) – List Function is used to save a list of string of
variable.
( < , >, >=, <=, = =, != ) – Comparison Operation/ Logical
Operation use to compare values and return True / False
for your logical pattern.
( : ) Colon – Used to closed the header of function
( ) Parenthesis – Used for input values or variables.
(input) Input Function – Used to communicate to a user
what to input on the open ended question
(int) Integer Function – Used to set of whole number on
a program.
(str ) String Function – Used to represent a set of
variable as text rather than a number.
(bool) Boolean Function – is a data type that represent a
two values of True or False.
( % ) Modulo Operator – return the remainder of a
division operation between two numbers, it is also to
represent a EVEN & ODD numbers.
print() Print Function – Used to send or show the output
of a variable.
( def ) or Define Function – Short for define used to
create or declare a function.
(return) Return Function – Used to send a result back to
the caller or def.
(continue) Continue Function – Used to skips the
current iteration and jumps to the next one.
( for ) Loop – Used for definite iteration or repeats a set
number of times.
(while) Loop – Used for indefinite iteration or repeats as
long as a specified condition remains True.
(range) Function – Used to set a number range on for
loop.
(.upper) Uppercase Function – Used to set the variables
into a uppercase letter.
(.lower) Lowercase Function – Used to set the variables
into a lowercase letter.
( count ) Count Function – Used to set a count of a
integers.
( if, elif, and else) Conditional Statements – Used for
decision making and controlling program flow.
( if ) Statement – If only one condition is true.
(elif) Statement – Used to check additional conditions or
another conditions.
(else) Statement – Used to catch all block of condition
that execute only if all preceding if and elif conditions
were false.
( <class> ) Function – Used to called out a type function
if it is class string or class boolean.
( class variable: ) Class Function – Used to called the
class variable on a program.
(variable_variable) Class Boolean – Used to call a
Boolean class.
(.append) Function – Is used to save an existing list.




"""


