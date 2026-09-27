class LetterChecker:
    def __init__(self, letter):
        """Initialize with a single letter"""
        self.letter = letter.lower()
        self.vowels = {'a', 'e', 'i', 'o', 'u'}
    
    def is_vowel(self):
        """Check if the letter is a vowel"""
        return self.letter in self.vowels
    
    def is_consonant(self):
        """Check if the letter is a consonant"""
        return self.letter.isalpha() and not self.is_vowel()
    
    def get_type(self):
        """Return the type of the letter"""
        if self.is_vowel():
            return "vowel"
        elif self.is_consonant():
            return "consonant"
        else:
            return "not a letter"
    
    def display(self):
        """Print the letter in lowercase and uppercase"""
        print(f"Lowercase: {self.letter.lower()}")
        print(f"Uppercase: {self.letter.upper()}")
        print(f"Type: {self.get_type()}")

# Example usage
if __name__ == "__main__":
    # Get input from user
    user_input = input("Enter a letter: ")
    
    # Create LetterChecker instance
    checker = LetterChecker(user_input)
    
    # Display results
    checker.display()

#while loops
name = input("Enter your name : ")

while name != "kevin":
print("you are not the right person")
name = input("Try again : ")

print("hey kevin")

guess = input("Enter your name : ")
i = 1

while guess != "a"
    i += 1
    guess = input("Try again : ")
print("guesses")

#letter checker
class LetterChecker:
    def check(self):
        letter = input("Enter a letter: ")
        letters = ["a", "e", "i", "o", "u"]
        if letter in letters:
            print(f"{letter.lower() and letter.upper()} is a Vowels.")
        else:
            print(f"{letter.lower() and letter.upper()} is not a Consonant.")

lc = LetterChecker()
lc.check()
