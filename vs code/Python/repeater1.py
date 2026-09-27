class Repeater: 
    def repeat(self): 
        word = int(input("Enter a Number: "))
        print(f"MULTIPLICATION TABLE OF {word}")
        for i in range(1,11): 
            result = word * i
            print(f"{word} x {i} = {result}") 
 
rep = Repeater() 
rep.repeat()

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

name = input("What is your name? ")
age = input("How old are you? ")
color = input("What is your favorite color? ")
print("Hi! My name is " + name + ", I am " + age + " years old, and I love thecolor " + color + ".")

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

Total 