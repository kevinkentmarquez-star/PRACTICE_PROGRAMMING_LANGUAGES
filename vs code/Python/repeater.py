class Repeater:
    def repeat(self):
        word = input("Enter a word: ")
        times = int(input("How many times: "))

        for r in range(times):
            print(word)
        
time = Repeater()
time.repeat()
