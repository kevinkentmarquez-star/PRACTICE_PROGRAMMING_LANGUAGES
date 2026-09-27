class Calculator:
    def calculate(self):
        num1 = int(input("Enter the first number: "))
        num2 = int(input("Enter the Second number: "))
        operation = input("Enter operation, +, -, *, / : ")

        if operation == "+":
            result = num1 + num2
            print(f"{Num1} + {Num2} = {result}")
        elif operation == "-":
            result = num1 - num2
            print(f"{num1} - {num2} = {result}")
        elif operation == "*":
            result = num1 * num2
            print(f"{num1} * {num2} = {result}")
        elif operation == "/":
            result = num1 / num2
            print(f"{num1} / {num2} = {result}")
        else:
            print("invalid number")

c = Calculator()
c.calculate()