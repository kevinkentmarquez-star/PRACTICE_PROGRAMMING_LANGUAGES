my_list = [1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9] # this the original list
print("Original list:", (my_list)) # this will print when program run it will print the list
print("Length of list:" , len(my_list)) # the lenght of the  list which is  1 - 9
y = 1

for x in range(len(my_list)): # the len of the list where it create the range of list 1 - 9
    x = 0, 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9
    if len(my_list):
        if [] == my_list:
            my_list.remove(my_list[x]) # if list 0 blank remove the 0 it will print 1 - 9
    else:
         y = y + 1 
         break # to stop the program code

print("\nThe list with unique elements only.") # for the final ouput 
print(my_list) # it will print the list 1 - 9