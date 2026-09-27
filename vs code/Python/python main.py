# strings
first_name = "kevin"
food = "pizza"
email = "kevinkentmarquez@gmail,com"

# integers
age = 25
quantity = 3
num_of_students = 30

#formating 
print(f"you age is {age}")

#float
price = 10.13

#boolean
is_students = True or False

if is_students:
    print("you are a student")
else:
    print("you are not student")

#example
is_student = False
for_sale - False

if for_sale:
    print("that item is for sale")
else:
    print("that item are not for sale")

#typecasting

name = "kevin"
age = 20
gpa = 1.2
is_student = True

print(type(name)) # str
print(type(age)) # int
print(type(gpa)) # float
print(type(is_student)) # boolean

#input() = function that prompts the user to enter data returns the entered data as a string

name = input("Enter your name: ")
age = input("Enter your age: ")

print(f"Hi {name!}")
print(f"Your age is {age}")

#1 rectangle area calc
lenght = float(input("Enter the lenght: "))
width = float(input("Enter the width: "))
area = lenght * width

print(f"The are is: {area}cm2")
# shopping cart program

item = input("what item would you like to buy: ")
price = float(input("What is the price: "))
quantity = int(input("How many would you like"))
total = price * quantity

print(f"you have bought {quantity} x {item}/s")
print(f"your total is: {total}")

#mablibs game
# word game where you create a story
# by filling in blanks with random words

adjective1 = input("Enter an adjective (description): ")
noun1 = input("Enter a noun (person , place . thing)")
adjective2 = input("Enter an adjective (description): ")
verb1 = input("Enter a verb ending with(ing)")
adjective3 = input("Enter an adjective (description): ")


print(f"Today i went to a {adjective1} zoo. ")
print(f"In an exhibit. i saw a |{noun1} ")
print(f"{noun1} was {adjective1} and {verb1}")
print(f"i was {adjective3}!")
# math
kevin = 5
kevin += 5
print(kevin)