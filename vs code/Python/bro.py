
#formating string
first_name = "kevin"
last_name = "Marquez"
age = 19
print(f"Hello {first_name} Your last name is {last_name} and you are {age} years old.")
# if statement and boolean
is_kevin = True

if is_kevin:
    print("Hi kevin")
else:
    print("You are not kevin")

#tycasting
name = "kevin"
age = 20
gpa = 3.1
is_it = True

print(type(name)) # return str
print(type(age)) # return int
print(type(gpa)) # return float
print(type(is_it)) # return bool

#example 

gpa = int(gpa)
print(age) # return 3 because int whole number
# same as float will return 20.0 
# age is str
age = str(age)
print(age) # return "20"

age = 25
age = int(age)

age += 1

print(age)

# if string 
age = 25
age = str(age)

age += 1

print(age)
#return it 251 years old
# typecasting - the process of converting  a variable from one date to another  str() float() bool() int()

#user input()
input("Enter your name: ")
#return "Enter your name "

name = input("Enter your name: ")
print(f" Hello {name}!")
#return your name as Hello {name}

# Exercise 1 Rectangle area calc

lenght = float(input("Enter a lenght: "))
width = float(input("Enter a width: "))
area = lenght * width
print(area)

print(f"The are is: {area}cm ")
# it will return have float because of arithmetic sequence

#shopping cart program

item = input("Enter a item: ")
price = float(input("Enter a price: "))
quantity = int(input("How many would you like: "))
total = price * quantity

print(f"You have bought {quantity} x {item}/s")
print(f"You total is : {total}")
# Enter a item: 1
    Enter a price: 2
    How many would you like: 3
    You have bought 3 x 1/s
    You total is : 6.0

#mablib games
#word game where you create a story
# by filling in blanks with random words

