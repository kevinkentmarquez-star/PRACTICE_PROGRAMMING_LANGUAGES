str = data types
string = just a variable or module name .not data type, one text Value 
# name = "kevin"
strings = # plural / not data type / multiple texts values 
# string name = "kevin"

# COMMON STRING

# name.upper() #JOHN
# name.lower() #john
# name.replace("J", "M") # MOHN
# name.strip()  remove spaces 

# list methods

students = ["John", "Maria", "John", "Eleigh", "Josh","Steven"]
# 6 items
print(students[0])
#output John

#Common list
students.append("Lorenz") # adds an item
students.remove("John") # removes an item
students.sort() A-Z or Z-A #sort the list 
students.reverse()

# Exception to avoid error 
# if an error occurs in your program
age = int("Hello")
try:
    age = int(input("Enter your age: "))
    print(age)
except ValueError:
    print("Please Enter your number")

# Operations on strings
# concatenated(joined)
"+variable+", {variable}
str1 = 'a'
str2 = 'b'
print(str1 + str2)
print(str2 + str1)
print(5*a)
print(4*a)

#ord function
#ASCII TABLE

char_1 = 'a'
char_2 = ' '

print(ord(char_1))
# output 97
print(ord(char_2))
# output : 32 

#chr function
print(chr(97))
# output: a
print(chr(45))
#output : -
