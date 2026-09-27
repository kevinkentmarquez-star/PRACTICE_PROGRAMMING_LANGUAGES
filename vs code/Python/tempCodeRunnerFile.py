class Calculator:
        
        def add(num1, num2):
            return num1 + num2
        
        def sub(num1, num2):
            return num1 - num2
        
        def multiply(num1, num2):
            return num1 * num2
        
        def divide(num1, num2):
            return num1 / num2
        
        def avg(num1, num2):
            return (num1 + num2)/2
        

print("Please Select a operation:\n " \
      "1. Addition\n" \
      "2. Subtraction\n" \
      "3. Multiplication\n" \
      "4.Division\n"\
      "5.Average\n")

select = int(input("Select a operation from 1,2,3,4,5: "))

number1 = int(input("Enter a First Number: "))
number2 = int(input("Enter a Second Number: "))

if select == 1:
    print(number1, "+" , number2, " =", \
          Calculator.add(number1, number2))
elif select == 2:
     print(number1, "-" , number2, " =", \
          Calculator.sub(number1, number2))
elif select == 3:
    print(number1, "*" , number2, " =", \
          Calculator.multiply(number1, number2))
elif select == 4:
    print(number1, "/" , number2, " =", \
          Calculator.divide(number1, number2))
elif select == 5:
    print("(", number1, "+" , number2, ")", "/", "2", " =", \
          Calculator.avg(number1, number2))
else:
    print("invalid operation pls select again")


