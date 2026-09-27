c# - it it object oriented programming language created by microsoft
c# has roots from the c family adn the language is close to other popular language like c++ 
and java


using System;

namespace Hello World
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}

Line 1 = using system means that we can use classes form the system namespace 
Line 2 = a blank line c# ignore white space. however, multiple lines make the code more readable
line 3 = namespace is used to organize your code , and it is a container for classes and other namespaces 
line 4 = curly braces [] makes the beginning and the end of a block of code
line 5 = class is a container for data and methods. which brings functionality to your program.
Every line of code that runs in c# must be inside a class.

#C# OUTPUT 
// to output values or print text in c# , you can use the WriteLine() method;
Console.WriteLine("Hello World");
Console.WriteLine("I learning c#");
Console.WriteLine("It is awesome");
you use alaso Write() method 
the difference is does not insert to a new line at the end of the output 

C# comments // 
multiple lines /* that ends */


== c# Variables ==
-a variales are containers for storing data values 

- int / stores integers ( whole numbers) without decimals such as 123 or -123
- double / stores floating point of numbers with decimals such as 19.99 or -19.99
- char / stores sginle characters such as 'a' or 'B'. Char values are surrounded single quotes
- string / stores text , such as "Hello World". String values surrounded by single quotes
- bool - stores values with two states ; true or false

== Declaring ( Creating ) Variables == 
type varialeName = value;

// Example 
string name = "John";
Console.WriteLine(name);
// Assign variable
int myNum;
myNum = 15;
Console.WriteLine(myNum);

// change value 
int myNum = 15;
myNum = 20; // myNum is now 20 
Console.WrieLine(myNum);

 // other types

 int myNum = 5;
 double myDoubleNum = 5.51;
 char myLetter = 'A';
 bool myBool = true;
 string myText = "Hello";

 == Constants == 
//  this will be declare the variable as "constant" which means unchangeable and read-only;
// Example
const int myNum = 40;
int myNum = 21; // ERROR BECAUSE IT IT UNCHANGEABLE
// NOTE ; YOU CANNOT DECLASE A CONSTANT VARIABLE WITHOUT ASSIGNING THE VALUE 

== Display Variables == 
// combine 
string name = "kevin";
Console.WriteLine("Hello" + name);

// Example 02 
string firstName = "kevin";
string lastName = "marquez";
string fullName = firstName + lastName:
Console.WrieLine(fullName);

// for numeric values
int x = 1;
int y = 2;
Console.WrieLine(x + y);

== Multiple Variables == 
// declare many variables 

int x = 5, y = 6, z = 60;
Console.WrieLine(x + y + z);

int x, y, z;
x = y = z = 50;
Console.WrieLine(x + y + z);

== Identifiers == 
//  c# variables must be identified with unique names.
// these unique names are called identifiers.
// Note ; it is recommended to use descriptive names in order to create understandable and maintainable code;

// Good
int minutesPerHour = 60;
// ok , but not so east to understand what m actuaally is
int m = 60;

 // names can contain letters , digits and underscore (_)
 // name must begin with a letter or underscore 
 // name should start with a lower case letter and cannot contain whitespace
 // names are case-sensitive ("myVar and myvar" are different variables)
 // reserved words like c# keywords like int or double cannot used as names.


 == DATA TYPES == 

 int myNum = 5; 
 double myDoubleNum = 5.51;
 char myLetter = 'A';
 bool myBool = true;
 string myText = "Hello"

 int // 4 BYTES // STORES WHOLE NUMBER FROM -2,147,483,648, to 2,147,483,647
 long // 8 bytes // stores whole numbers from -9,223,372,036,854,775,808 to -9,223,372,036,854,775,807
 float // 4 bytes // stores fractional numbers. Sufficient for storing 6 to 7 decimal digits 
 double // 8 bytes // stores fractional numbers. Sufficient for storing 15 decimal digits
 bool // 1 byte // stores true or false values.
 char // stores a single character / letter , surrounded by single quotes
 string // 2 bytes per character // stores a sequence of characters , surrounded by double quotes.

// integer type
int myNum = 14;
//long type 
long myNum = 160000L;
Console.WriteLine(myNum);
// floating point types 
float myNum = 5.1F;
Console.WriteLine(myNum);
// double 
double myNum = 19.99D;
Console.WriteLine(myNum);

// a floating  point number can also be specific number with an "e" indicate the power of 10 
float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);

// string 
string greeting = "Hello World";
Console.WrieLine(greeting);

== TYPE CASTING == 
// implicit casting ( automatically ) - converting a smaller type to a larger type of size 
char -> int -> long -> float -> double 
// explicit casting ( manually )- converting a larger type to a smaller size type 
double -> float -> long -> int -> char 
// implicit casting
using system

namespace MyLearningJourney
{
    class program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = myInt; // automatic casting into double 
            Console.WriteLine(myInt); // OUT PUT IS 9 
            Console.WriteLine(myDouble); // OUT PUT IS 9
        }
    }
}
// explicit 
using system 
{
    class program
    {
        static void Main(string[] args)
        {
            double myDouble = 9.65;
            int myInt = (int) myDouble;
            Console.WriteLine(myDouble); // OUTPUT IS 9.65
            Console.WrieLine(myInt); // OUTPUT IS 9 
        }
    }
}

 // TYPE CONVERSION METHODS // 

 int myInt = 10;
 double myDouble = 5.42;
 bool myBool = true;

 Console.WrieLine(Convert.ToString(myInt)); // convert int to string
 Console.WrieLine(Convert.ToDouble(myInt)); // convert int to double 
 Console.WrieLine(Convert.ToInt32(myDouble)); // convert double to int
 Console.WriteLine.(Convert.ToString(myBool)); // convert bool to string 

 == GET USER INPUT == 

// TYPE YOUR USERNAME AND PRESS ENTER 
Console.WriteLine("Enter username: ");

// Create a string variable and get user input from the keyboard and store it in the variable 
string username = Console.ReadLine();

// print the value of the variable (username) , which will display the input value
Console.WriteLine("Username is: " + username);

user system
{
    class MyLearningJourney
    {
        static void Main(string[] args)
        [
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Username is:" + username);
        ]
    }
}

// console.ReadLine() method returns a string. you cannot get information from another data type such as int. it can cause error #cannot implicity convert type 'string' to 'int'

== Convert.To() methods == 

Console.WriteLine("Enter you age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

== C# OPERATORS == 

int x = 100 + 50;
// EXAMPLE 
int sum1 = 100 + 50; // 150 (100 + 50)
int sum2 = sum1 + 250; // 400 (150 + 250)
int sum3 = sum2 + sum2; // 800 ( 400 + 400)

/*
addition + ( x + y)
subtraction - (x - y)
multiplication * (x * y)
division / ( x / y)
modulus % (x % y) returns the division remainder 
increment ( ++ ) increases the value of a variable by 1 ( x++ )
decrement ( -- ) decreases the value of a variable by 1 ( x-- )
*/

== Assignment Operatos == 
int x = 10;
x += 5; // 15

/* 
(=) x = 5 same as x = 5
(+=) x += 3 same as x = x + 3
(-=) x-= 3 same as x = x - 3
(*=) x *= 3 same as x = x * 3
(/=) x /= 3 same as x = x / 3
(%=) %= 3 same as x = x % 3
(&=) &= 3 same as x = x & 3
(|=) |= 3 same as x = x | 3
(^=) ^= 3 same as x = x ^ 3
(>>=) >>= 3 same  x = x >>= 3
(<<=) <<= same as x = <<= 3 
*/


== Comparison Operators == 
int x = 5;
int y = 3;
Console.WrieLine(x > y); // return true because 5 is greater than 3

(==) Equal to x == y 
(!=) is not Equal to  x != y
(>) greater than x > y
(<) less than x < y 
(>=) greather than or equal to x >= y
(<=) less than or equalt to x <= y 


== LOGICAL OPERATORS == 

&& lOGICAL and // return true if both statements are true x < 5 && x < 10 
|| Logical or  // return true if one of the statements is true x < 5 || x < 4
! Logical not // reverse the result, returns true if false, false if true  !(x < 5 && x < 10)

== C# MATH == 
// Math.Max(x,y) method can be used to find the highest value of x and y
Math.Max(5, 10); // output is 10
// Math.Min(x,y) method can be ysed to find the lowest value of x and y)
Math.Min(5 , 10); // output is 5 
// Math.Sqrt(x) method returns the square root of x
Math.Sqrt(64); // output is 8
// Math.Abs(x) method returns the absolute (possitive value of x ) 
Math.Abs(-4.7); // output is 4.7
// Math.Round() rounds a number to the nearest whole number 
Math.Round(9.99); // output is 10 

== C# strings == 
// string variable contains a collection of characters surrounded by a double quotes
string greeting = "Hello";
// contains many words if you want
string greeting2 = "Hello world, Im learning C#";
// Length property 
string txt = "ithgna";
Console.WriteLine("The lenght of the txt string is: " + txt.Length);

// other methods ToUpper() and ToLower()
string txt = "Hello World";
Console.WriteLine(txt.ToUpper()); // outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower()); // outputs "hello world"

== STRING CONCATENATION == 

string firstName = "kevin";
string lastName = "marquez";
string name = (firstname.ToUpper() + lastName.ToLower());
Console.WriteLine(name);

// you can also used the string.Concat() method to concatenate two strings:

string firstName = "kevin";
string lastName = "marquez";
string name = string.Concat(firstName, lastName);
Console.WrieLine(name);

// adding numbers and string
// numbers are added . strings are concatenated
int x = 14;
int y = 5;
int z = x + y; // output is 19 

// string
string x = "10";
string y = "4";
string z = x + y; // output is 104

== String Inperpolation == 
// another option of string concatenation is string interpolation 
string firstName = "kevin";
string lastName = "marquez";
string name = $"My Full Nmae is: {firstName} {lastName}";


== Acess Strings == 
// you can access the characters in a string by referring to its index number inside square brackers []
string myString = "hello";
Console.WriteLine(myString[0]); // OUTPUT IS h because it indicates the number of string from 0.
// you can also find the index possition of a specific character in a string by using the IndexOf() method.
string myString = "Hello";
Console.WrieLine(myString.IndexOf("e")); // outputs will be 1

//another useful metod is Substring() which extracts the characters from a string starting from the specified chracter posstion/index and returns a new string.
// this method is often used together with IndexOf() to get specific chracter position;

using system;

namespace GetLastname
{
    class Program
    {
        static void Main()
        {
        // Full name
        string name = "kevin kent marquez";

        // location of the M
        int charPost = name.IndexOf("m");

        // get last name
        string lastName = name.Substring(charPost);
        
        // print the result
        Console.WriteLine(lastName); // out put is marquez
        }
    }
}

== STRING CHRACTERS == 

// because strings must be written within quotes c# will misunderstand this string and generate an error
// Example 
string txt = "We are the so-called" "Vikings" from the north:";
// the solution to avoid this problem is to use the backslash escape character.

// The backslash (\) escape character turns special characters into string characters;
\' // single quote 
\" Double quote
\\ backslash
string txt = " We are the so-called \ "Vikings\" from the north,";
// \'
string txt = "It\' alright,";
// \\
string txt = "The character \\ is called backslash,";

// other useful escape characters 
// \n new line
// \t tab 
// \b back space 

== C# BOOLEANS == 

// YES / NO
// ON / OFF
// TRUE / FALSE 

// BOOL TYPE CONTAIN TRUE OR FALSE 

bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun); // outputs True 
Console.WriteLine(isFishTasty); // outputs False 

// BOOLEAN EXPRESSION
// you can use a comparison operator such as the greater than (>)
int x = 10;
int y = 9;
Console.WriteLine(x > y); // returns true, because 10 is greater than 9
Console.WriteLine(10 > 9);

// == 
int x 10;
Console.WriteLine(x == 10); // returns true, because the value of x is equal to 10.

== REAL LIFE EXAMPLE == 
int myAge = 21;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);


// if and else statement 
using System;
namespace VotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 21;
            int votingAge = 18;

            if myAge >= votingAge;
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote");
            }
        }
    }
}


== IF ELSE STATEMENT == 

// C# Conditions and if statements 
// Use if to specify a block of code to be executed , if a specided condition is true
// Use else else to specify a block of code to be executed . if the same condition is false
// Use else if to specify a new condition to test , if the first condition is false
// Use switch to specify many alternative blocks of code to be executed 

// use if statement to be executed if a condition is True.

if (condition)
{
    // block of code to executed if the condition is true
}
// use lowercase if not IF it can cause error 

// example if (20 > 19)
{
    Console.WriteLine("20 is greater than 19");
}

// example 2 
int x = 20;
int y = 19;
if (x > y)
{
    Console.WriteLine("X is greather than y");
}

== ELSE STATEMENT == 

if (condition)
{
    // block of code to be executed if the condition is true
}
else
[
    // block of code to be execute if the condition is false
]

using System;

namespace Myapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 15;
            if (time < 18)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        }
    }
}

== ELSE IF STATEMENT == 

if (condition)
{
    // block of code to be executed if condition is true
}
else if (condition)
{
    // block of code to be executed if the condition1 is false and condition2 is true
}
else
{
    // block of code to be executed if both condition is false 
}

// example

using system;

namespace Myapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }
        }
    }
}

== SHORT HAND IF... ELSE (TERNARY OPERATOR)

// Syntax 
// variable = (condition) ? expressionTrue : expressionFalse

int time = 20;
string result = (time < 18) ? "Good Day." : "Good evening.";
Console.WriteLine(result);


== SWITCH STATEMENTS == 
// USE THE SWITCH STATEMENT TO SELECT ONE OF MANY CODE BLOCKS TO BE EXECUTED

switch (expression)
{
    case x:
    // code block
    break;
    case y:
    //code block
    break;
    case z:
    // code block
    break;
}

// The switch expression is evaluated once
// the value of the expression is compared with tha values of each case
// of there is a match the associated block of code is executed 

using System;
namespace Myapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 4;
            switch (day)
            {
                case 1:
                Console.WriteLine("Monday");
                break;
                case 2:
                Console.WriteLine("Tuesday");
                break;
                case 3:
                Console.WriteLine("Wednesday");
                break;
                case 4:
                Console.WriteLine("Thursday");
                break;
                case 5:
                Console.WriteLine("Friday");
                break;
                case 6:
                Console.WriteLine("Saturday");
                break;
                case 7:
                Console.WriteLine("Sunday")
                break;
            }
        }
    }
}

// the break keyword it breaks out of the switch block 
// this will stop the execution of more code and case testing inside the block
// when a match a found and the job is done it's time for a break . there is no need for more testing 

// Default keyword is optional and specifies some code to run if there no case match;
int day = 4;
switch (day)
{
    case 1:
    Console.WriteLine("Today is Tuesday");
    break;
    case 2:
    Console.WriteLine("Today is Sunday");
    break;
    default:
    Console.WriteLine("Today is Monday");
    break;
}   
// output is Today is Monday 

== WHILE LOOP == 
// loops can execute a block of a code as long as a specified condition is reached.
// loops are handy because they save time ,reduce errors, and they make code more readable.

== C# WHILE LOOP == 
// the while loop, loops through a block of code as long as a specified condition is True;
while (condition)
{
    // code of block to be executed
}
int i = 0
while (i > 5)
{
    Console.WriteLine(i);
    i++;
}
// the code in the loop will run over and over again as long as a variable i is less than 5
// do not forget to increase the variable used in the condition, otherwise the loop will never end!

// The Do/While Loop
// the do/while loop is a variant of the while loop. this loop will execute the block once, because checking if the condition is true . then it will repeat the loop as long as the condition true
do
{
    // code block to be executed
}
while (condition);

// example of do/while loop.
// the loop will always be executed at least once, even if the condition is false , because the code block is executed before the condition is tested 
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
}
while (i < 5);

== FOR LOOP == 
// when you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop.

for (statement 1; statement 2; statement3)
{
    // code block to be executed
}
// statement 1 : is executed (one time) before the execution of the code block 
// statement 2 : defines the condition for executing the code block
// statement 3 : executed (every time) after the code block has been executed

for (int i = 0; i > 5; i++)
{
    Console.WriteLine(i);
}
// statement 1 sets a variable before the loop starts ( int i = 0).
// statement 2 defines the condition for the loop to run ( i must be less than 5). if the condition is true the loop will start over again. if it is false the loop will end
// starment 3 increase a value (i++) each time the block has been executed

// example between 0 - 10
for (int i = 0; i < 10; i++)
{
    Console.WrieLine(i);
}


== NESTED LOOPS == 
// it is also possible to place a loop inside another loop . this called a nested loop
// the "inner loop" will be executed one time each iteration of the "outer loop"

// example

//  outer loop 
for (int i = 1; i <= 2; i++)
{
    Console.WriteLine("Outer: " + i); // executed 2 times
    
    // inner loop 
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine("Inner: " + j); // executed 6 times ( 2 * 3)
    }
}

== Foreach LOOP == 

// there is alaso foreach loop, which is used exclusively to loop through elements in an array for other data sets.

// syntax

foreach (type variableNmae in arrayName)
{
    // code block to be executed
}

// example 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars)
{
    Console.WrieLine(i);
}

== BREAK AND CONTINUE ==

// c# break 
// it was used to "jump out" of a switch statement
// the break statement can also be used to jump out of loop
// example jumps out of the loop when i equat to 4:

for (int i 0; i < 10; i++)
{
    if (i == 4)
    {
        break;
    }
    Console.WriteLine(i);
}

// c# continue 
// continue statement breaks one iteration (in the loop) if a specified condition occurs and continues with the next iteration in the loop.

// example skips the value of 4;

for (int i = 0; i < 10; i++)
{
    if (i = 4)
    {
        continue;
    }
    Console.WriteLine(i);
}

// break and continue in while loop

// you can also use break and continue in while loops 
// break example
int i = 0;
while (i < 10)
{
    Console.WrieLine(i);
    i++;
    if(i = 4)
    {
        break;
    }
}
// continue example

int i = 0;
while (i < 10)
{
    if (i == 4)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}

== c# arrays == 
// arrays used to store multiple values in a single variable , instead of declaring separate variables for each value.
// to declare an array, define the variable type with square brackets

string[] cars;

// to insert values to it , we can use an array literal - place the values in a comma,separated list.
// inside curcly braces;

string[] cars = {"Volvo" , "BMW", "Ford", "Mazda"};
// to create an array of integers
int[] myNum = {10,20,30,40,50};

// access the elements of an array 
// you can access an array element by referring to the index number 
// this statement accesses the value of the first element in cars;

string[] cars = {"Volvo", "Bmw", "Ford", "Mazda"};
Console.WriteLine()

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]);
// Outputs Volvo

// change an array element 
// the change the value of a specific elemet refer to the index number
cars[0] = "Opel";

// example 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Opel";
Console.WriteLine(cars[0]);
// Now outputs Opel instead of Volvo

== Array Length == 
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars.Length);
// Outputs 4

// Other Ways to Create an Array
// If you are familiar with C#, you might have seen arrays created with the new keyword, and perhaps 
// you have seen arrays with a specified size as well. In C#, there are different ways to create an array:

// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// It is up to you which option you choose. In our tutorial, we will often use the last option, as it is faster and easier to read.

// However, you should note that if you declare an array and initialize it later, you have to use the new keyword:

// Declare an array
string[] cars;

// Add values, using new
cars = new string[] {"Volvo", "BMW", "Ford"};

// Add values without using new (this will cause an error)
cars = {"Volvo", "BMW", "Ford"};

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array
            string[] cars;

            // add values , usign new
            cars = new string[] {"Volvo", "BMW", "FORD"};

            // THIS WOULD CAUSE AN ERROR; cars = {"Volvo, "BMW", "Ford"};
            Console.WriteLine(cars[0]);
        }
    }
}

== c# loop through an array == 
 // You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

 string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}
/* output is
 Volvo
BMW
Ford
Mazda 
*/

== THE Foreach LOOP == 
// There is also a foreach loop, which is used exclusively to loop through elements in an array:

foreach (type variableName in arrayName) 
{
  // code block to be executed
}

// The following example outputs all elements in the cars array, using a foreach loop:
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
/* output is
 Volvo
BMW
Ford
Mazda 
*/
/* The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.
If you compare the for loop and foreach loop, you will see that the foreach method is easier 
to write, it does not require a counter (using the Length property), and it is more readable. */

 // FOREACH iterate through each element in an array without requiring a counter?

== C# SORT ARRAYS == 

// There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:

// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
 
// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
}
// OUTPUT IS
// BMW

Ford
Mazda
Volvo
1
5
8
9


// System.Linq Namespace
Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // largest value
      Console.WriteLine(myNumbers.Min());  // smallest value
      Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
    }
  }
}

== C# Multidimensional Arrays == 
// about arrays, which is also known as single dimension arrays.
// if you want to store data as a tabular form, like a table with rows and columns, you need to get familiar with multidimensional arrays.

A multidimensional array is basically an array of arrays.

Arrays can have any number of dimensions. The most common are two-dimensional arrays (2D).
 
 == Two-Dimensional Arrays == 
  // To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the square brackets:
  int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
// Good to know: The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].
// numbers is now an array with two arrays as its elements. The first array element contains three elements: 1, 4 and 2, 
// while the second array element contains 3, 6 and 8. To visualize it, think of the array as a table with rows and columns:
// row 0 contains 1 , 4, 2 while row1 contains 3, 6, 8

== Access Elements of a 2D Array ==
// To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array.
//  Or better yet, with the table visualization in mind; one for the row and one for the column (see example below).
 // This statement accesses the value of the element in the first row (0) and third column (2) of the numbers array:

 int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine(numbers[0, 2]);  // Outputs 2

// note Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

// Change Elements of a 2D Array
// You can also change the value of an element.

// the following example will change the value of the element in the first row (0) and first column (0):

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
      numbers[0, 0] = 5;
      Console.WriteLine(numbers[0, 0]);
    }
  }
}

== Loop Through a 2D Array == 
// you can easily loop through the elements of a two-dimensional array with a foreach loop:
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

foreach (int i in numbers)
{
  Console.WriteLine(i);
} 

// You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.

// Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:

int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

for (int i = 0; i < numbers.GetLength(0); i++) 
{ 
  for (int j = 0; j < numbers.GetLength(1); j++) 
  { 
    Console.WriteLine(numbers[i, j]); 
  } 
} 
/* output is 1
4
2
3
6
8 */

 == C# Methods == 
 // A method is a block of code which only runs when it is called.

 // You can pass data, known as parameters, into a method.

// Methods are used to perform certain actions, and they are also known as functions.

// Why use methods? To reuse code: define the code once, and use it many times.

// Create a Method 
A method is defined with the name of the method, followed by parentheses (). 
C# provides some pre-defined methods, which you already are familiar with, such as Main(), 
but you can also create your own methods to perform certain actions:

class Program
{
  static void MyMethod() 
  {
    // code to be executed
  }
}

MyMethod() is the name of the method
static -> means that the method belongs to the Program class and not an object of the Program class. You will learn more about 
objects and how to access methods through objects later in this tutorial.
void -> means that this method does not have a return value. You will learn more about return values later in this chapter

// Inside Main(), call the myMethod() method:
static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
}

// Outputs "I just got executed!"
// A method can be called multiple times:

static void MyMethod() 
{
  Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
  MyMethod();
  MyMethod();
  MyMethod();
}

// I just got executed!
// I just got executed!
// I just got executed!

 ==  C# Method Parameters ==
 // Parameters and Arguments 
 // Information can be passed to methods as parameter. Parameters act as variables inside the method.
 // They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.
 
 // The following example has a method that takes a string called fname as parameter. 
 //  When the method is called, we pass along a first name, which is used inside the method to print the full name:

 static void MyMethod(string fname) 
{
  Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
  MyMethod("Liam");
  MyMethod("Jenny");
  MyMethod("Anja");
}

// Liam Refsnes
// Jenny Refsnes
// Anja Refsnes
// When a parameter is passed to the method, it is called an argument. So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.

 == Multiple Parameters ==
 // You can have as many parameters as you like, just separate them with commas:

static void MyMethod(string fname, int age) 
{
  Console.WriteLine(fname + " is " + age);
}

static void Main(string[] args)
{
  MyMethod("Liam", 5);
  MyMethod("Jenny", 8);
  MyMethod("Anja", 31);
}

// Liam is 5
// Jenny is 8
// Anja is 31

 // Note that when you are working with multiple parameters, the method call must have the same number 
 // of arguments as there are parameters, and the arguments must be passed in the same order.

  == C# Default Parameter Value ==
  // You can also use a default parameter value, by using the equals sign (=).

// If we call the method without an argument, it uses the default value ("Norway"):

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string country = "Norway")
    {
      Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
  }
}

// A parameter with a default value, is often known as an "optional parameter". 
// From the example above, country is an optional parameter and "Norway" is the default value.


 == C# Return Values == 
 // In the previous page, we used the void keyword in all examples, which indicates that the method should not return a value.

 // If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:
 using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x)
    {
      return 5 + x;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(3));
    }
  }
}
// 8 

// this example returns the sum of a method's two parameters:
using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      Console.WriteLine(MyMethod(5, 3));
    }
  }
}


// You can also store the result in a variable (recommended, as it is easier to read and maintain):

using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int z = MyMethod(5, 3);
      Console.WriteLine(z);
    }
  }
}
// // Outputs 8 (5 + 3)

// return - It ends the method and returns control to the caller.

 == C# Named Arguments ==
 // It is also possible to send arguments with the key: value syntax.

// That way, the order of the arguments does not matter:

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string child1, string child2, string child3)
    {
      Console.WriteLine("The youngest child is: " + child3);
    }

    static void Main(string[] args)
    {
      MyMethod(child3: "John", child1: "Liam", child2: "Liam");
    }
  }
}
// The youngest child is: John

== C# Method Overloading ==
// With method overloading, multiple methods can have the same name with different parameters:
int MyMethod(int x)
float MyMethod(float x)
double MyMethod(double x, double y)

// Consider the following example, which has two methods that add numbers of different types:
using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethodInt(int x, int y)
    {
      return x + y;
    }

    static double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}
//  Int: 13
// Double: 10.559999999999999

// Instead of defining two methods that should do the same thing, it is better to overload one.

// In the example below, we overload the PlusMethod method to work for both int and double:
using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}

== C# OOP == 
// OOP stands for Object-Oriented Programming.
// Procedural programming is about writing procedures or methods that perform operations on the data, 
// while object-oriented programming is about creating objects that contain both data and methods.
//  Object-oriented programming has several advantages over procedural programming:
// OOP provides a clear structure for the programs
// OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
// OOP makes it possible to create full reusable applications with less code and shorter development time
// Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes
// that are common for the application, and place them at a single place and reuse them instead of repeating it.

 == C# - What are Classes and Objects? ==
 // Classes and objects are the two main aspects of object-oriented programming.

// Look at the following illustration to see the difference between class and objects:
class = fruit
objects = apple , banana , mango 
// another example
class car 
objects = volvo , audi , toyota
// So, a class is a template for objects, and an object is an instance of a class.
// When the individual objects are created, they inherit all the variables and methods from the class.
// You will learn much more about classes and objects in the next chapter.

 == C# Classes and Objects == 
 Everything in C# is associated with classes and objects, along with its attributes and methods. For example: 
 in real life, a car is an object. The car has attributes, such as weight and color, and methods, such as drive and brake.
A Class is like an object constructor, or a "blueprint" for creating objects.

== Create a Class == 
 // To create a class, use the class keyword:
  // create a class named "Car" with a variable color:
class Car 
{
  string color = "red";
}

// When a variable is declared directly in a class, it is often referred to as a field (or attribute).

//It is not required, but it is a good practice to start with an uppercase first letter when naming classes.
//  Also, it is common that the name of the C# file and the class matches, as it makes our code organized. However it is not required (like in Java).

== Create an Object == 
// An object is created from a class. We have already created the class named Car, so now we can use this to create objects.
//To create an object of Car, specify the class name, followed by the object name, and use the keyword new:
 == Create an object called "myObj" and use it to print the value of color: == 

 using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
    }
  }
}
// Note that we use the dot syntax (.) to access variables/fields inside a class 
// (myObj.color). You will learn more about fields in the next chapter.

== C# Multiple Classes and Objects == 
// Multiple Objects
// You can create multiple objects of one class:

// Create two objects of Car:
using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      Car myObj1 = new Car();
      Car myObj2 = new Car();
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj2.color);
    }
  }
}
// red red 
== Using Multiple Classes == 
You can also create an object of a class and access it in another class. 
This is often used for better organization of classes (one class has all the fields and methods, while the other class holds the Main() method (code to be executed)).

prog2.cs
class Car 
{
  public string color = "red";
}
prog.cs
class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
Did you notice the public keyword? It is called an access modifier, which specifies that the color variable/field of Car is accessible for other classes as well, such as Program.

You will learn much more about access modifiers and classes/objects in the next chapters.

 == C# Class Members == 
 // Class Members
// Fields and methods inside classes are often referred to as "Class Members":

// Create a Car class with three class members: two fields and one method.

// The class
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 200;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}

 == Fields == 
 // In the previous chapter, you learned that variables inside a class are called fields, and that you can access them by creating an object of the class, and by using the dot syntax (.).

// The following example will create an object of the Car class, with the name myObj. Then we print the value of the fields color and maxSpeed:
using System;

namespace MyApplication
{
  class Car 
  {
    string color = "red";
    int maxSpeed = 200;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}
// red 200

// You can also leave the fields blank, and modify them when creating the object: 
//filename: Car.cs
using System;

namespace MyApplication
{
  class Car 
  {
    string color;
    int maxSpeed;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.color = "red";
      myObj.maxSpeed = 200;
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}

// This is especially useful when creating multiple objects of one class:

//filename: Car.cs
using System;

namespace MyApplication
{
  class Car 
  {
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}
 // Mustang Astra

 == Object Methods == 
  // You learned from the C# Methods chapter that methods are used to perform certain actions. 
  // Methods normally belong to a class, and they define how an object of a class behaves.
  // Just like with fields, you can access methods with the dot syntax. However, note that the method must be public. 
  // And remember that we use the name of the method followed by two parentheses () and a semicolon ; to call (execute) the method:
  

  using System;

namespace MyApplication
{
  class Car
  {
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
      Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.fullThrottle();  // Call the method
    }
  }
}
// The car is going as fast as it can!

 // Why did we declare the method as public, and not static, like in the examples from the C# Methods Chapter?

// The reason is simple: a static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.

 == Use Multiple Classes ==

 // Remember from the last chapter, that we can use multiple classes for better organization 
 // (one for fields and methods, and another one for execution). This is recommended:

 prog2.cs
 class Car 
{
  public string model;
  public string color;
  public int year;
  public void fullThrottle()
  {
    Console.WriteLine("The car is going as fast as it can!"); 
  }
}
prog.cs
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}
// Mustang Astra 

// The public keyword is called an access modifier, which specifies that the fields of Car are accessible for other classes as well, such as Program.

// You will learn more about Access Modifiers in a later chapter.

// Tip: As you continue to read, you will also learn more about other class members, such as constructors and properties.

 == C# Constructors == 

 // A constructor is a special method that is used to initialize objects. 
 // The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields:

 // Create a constructor:
 using System;

namespace MyApplication
{
  // Create a Car class
  class Car
  {
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
      model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
      Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
      Console.WriteLine(Ford.model);  // Print the value of model
    }
  }
}
// Mustang 
// Note that the constructor name must match the class name, and it cannot have a return type (like void or int).

// Also note that the constructor is called when the object is created.

// All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.

// Constructors save time! Take a look at the last example on this page to really understand why.

 == Constructor Parameters == 
 // Constructors can also take parameters, which is used to initialize fields.
 /* The following example adds a string modelName parameter to the constructor. Inside the constructor we set model to modelName (model=modelName).
  When we call the constructor, we pass a parameter to the constructor ("Mustang"), which will set the value of model to "Mustang": */

  
//filename: Car.cs
using System;

namespace MyApplication
{
  class Car
  {
    public string model;

    // Create a class constructor with a parameter
    public Car(string modelName)
    {
      model = modelName;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang");
      Console.WriteLine(Ford.model);
    }
  }
}

// You can have as many parameters as you want:
using System;

namespace MyApplication
{
  class Car
  {
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
      model = modelName;
      color = modelColor;
      year = modelYear;
    }

    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
  }
}
 // Red 1969 Mustang

 // Tip: Just like other methods, constructors can be overloaded by using different numbers of parameters. 

  == Constructors Save Time == 
  // When you consider the example from the previous chapter, you will notice that constructors are very useful, as they help reducing the amount of code:

  // Without constructor:
  using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}
// Mustang
// Astra

// With constructor:

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car("Mustang", "Red", 1969);
      Car Opel = new Car("Astra", "White", 2005);

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}
// Mustang
// Astra
// contructor A method used to initialize objects when they are created.


== C# Access Modifiers == 
== Access Modifiers
By now, you are quite familiar with the public keyword that appears in many of our examples: == 
//
public string color;

// The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

C# has the following access modifiers:

Modifier	Description
public	The code is accessible for all classes
private	The code is only accessible within the same class
protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal	The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
There's also two combinations: protected internal and private protected.

For now, lets focus on public and private modifiers.

 // Private Modifier 
 // If you declare a field with a private access modifier, it can only be accessed within the same class:

 using System;

namespace MyApplication
{
  class Car
  {
    private string model = "Mustang";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.model);
    }
  }
}
// Mustang 

If you try to access it outside the class, an error will occur:
class Car
{
  private string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
// error

// Public Modifier 
// If you declare a field with a public access modifier, it is accessible for all classes:
class Car
{
  public string model = "Mustang";
}

class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.model);
  }
}
// Mustang

// Why Access Modifiers?
// To control the visibility of class members (the security level of each individual class and class member).

// To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.
//  This is done by declaring fields as private. You will learn more about this in the next chapter.

// Note: By default, all members of a class are private if you don't specify an access modifier:
class Car
{
  string model;  // private
  string year;   // private
}

 == C# Properties (Get and Set) == 
 Properties and Encapsulation
// Before we start to explain properties, you should have a basic understanding of "Encapsulation".
// The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
// declare fields/variables as private
// provide public get and set methods, through properties, to access and update the value of a private field


 == Properties == 
 Properties
// You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.

// A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}

Example explained
// The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.
// The get method returns the value of the variable name.
// The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.

// If you don't fully understand it, take a look at the example below.

//Now we can use the Name property to access and update the private field of the Person class:

class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
// Liam

 == Automatic Properties (Short Hand) 
 // C# also provides a way to use short-hand / automatic properties, where you do not have to define the field for the property, and you only have to write get; and set; inside the property.

// The following example will produce the same result as the example above. The only difference is that there is less code:

// Using automatic properties: 
class Person
{
  public string Name  // property
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}
// Liam

// Why Encapsulation? 
// Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
// Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
// Flexible: the programmer can change one part of the code without affecting other parts
// Increased security of data

 == C# Inheritance == 

 // Inheritance (Derived and Base Class)
// In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

// Derived Class (child) - the class that inherits from another class
// Base Class (parent) - the class being inherited from
// To inherit from a class, use the : symbol.

// In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):

class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}

 // Why And When To Use "Inheritance"?
- //  It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.

//  Tip: Also take a look at the next chapter, Polymorphism, which uses inherited methods to perform different tasks.

 == The sealed Keyword == 

 // If you don't want other classes to inherit from a class, use the sealed keyword:

 sealed class Vehicle 
{
  ...
}

class Car : Vehicle 
{
  ...
}

 // 'Car': cannot derive from sealed type 'Vehicle'

  == C# Polymorphism == 

  // Polymorphism and Overriding Methods 

  // Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.
  // Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.

// For example, think of a base class called Animal that has a method called animalSound(). Derived classes of Animals could be Pigs, Cats, Dogs, Birds - 
// And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):

class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

// Remember from the Inheritance chapter that we use the : symbol to inherit from a class.

// Now we can create Pig and Dog objects and call the animalSound() method on both of them:

class Animal  // Base class (parent) 
{
  public void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}

// The animal makes a sound
 // The animal makes a sound
// The animal makes a sound

// Not The Output I Was Looking For
// The output from the example above was probably not what you expected. That is because the base class method overrides the derived class method, when they share the same name.

// However, C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods:


class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}

// The animal makes a sound
//he pig says: wee wee
 // The dog says: bow wow

 // Why And When To Use "Inheritance" and "Polymorphism"?
 // - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.

  == C# Abstraction == 
   //  Data abstraction is the process of hiding certain details and showing only essential information to the user.
// Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

// The abstract keyword is used for classes and methods:

// Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

// Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
// An abstract class can have both abstract and regular methods:

abstract class Animal 
{
  public abstract void animalSound();
  public void sleep() 
  {
    Console.WriteLine("Zzz");
  }
}
// From the example above, it is not possible to create an object of the Animal class:
// Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')

// To access the abstract class, it must be inherited from another class. Let's convert the Animal class we used in the Polymorphism chapter to an abstract class.

// Remember from the Inheritance chapter that we use the : symbol to inherit from a class, and that we use the override keyword to override the base class method.

// Abstract class
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}

// Why And When To Use Abstract Classes and Methods?
// To achieve security - hide certain details and only show the important details of an object.

// Note: Abstraction can also be achieved with Interfaces, which you will learn more about in the next chapter.

 == C# Interface == 

 Interfaces
Another way to achieve abstraction in C#, is with interfaces.

An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):

// interface
interface Animal 
{
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}

It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.
By default, members of an interface are abstract and public.
Note: Interfaces can contain properties and methods, but not fields.

To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class.
To implement an interface, use the : symbol (just like with inheritance). The body of the interface method is provided by the "implement" class. 
Note that you do not have to use the override keyword when implementing an interface:

// Interface
interface IAnimal 
{
  void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }
}

// Notes on Interfaces:
Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
Interface methods do not have a body - the body is provided by the "implement" class
On implementation of an interface, you must override all of its methods
Interfaces can contain properties and methods, but not fields/variables
Interface members are by default abstract and public
An interface cannot contain a constructor (as it cannot be used to create objects)
Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).

2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces,
because the class can implement multiple interfaces. Note: 
To implement multiple interfaces, separate them with a comma (see example in the next chapter).

 == C# Multiple Interfaces == 
 Multiple Interfaces
To implement multiple interfaces, separate them with a comma:

using System;

namespace MyApplication
{
  interface IFirstInterface
  {
    void myMethod(); // interface method
  }

  interface ISecondInterface
  {
    void myOtherMethod(); // interface method
  }

  // Implement multiple interfaces
  class DemoClass : IFirstInterface, ISecondInterface
  {
    public void myMethod()
    {
      Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("Some other text...");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      DemoClass myObj = new DemoClass();
      myObj.myMethod();
      myObj.myOtherMethod();
    }
  }
}

// Some text..
 // Some other text...

 == C# Enum == 

 C# Enums
An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:

// example 
enum Level 
{
  Low,
  Medium,
  High
}

// You can access enum items with the dot syntax:
Level myVar = Level.Medium;
Console.WriteLine(myVar);

 Enum is short for "enumerations", which means "specifically listed".

 // Enum inside a Class
// You can also have an enum inside a class:

 class Program
{
  enum Level
  {
    Low,
    Medium,
    High
  }
  static void Main(string[] args)
  {
    Level myVar = Level.Medium;
    Console.WriteLine(myVar);
  }
}

// Medium 

// Enum Values
// By default, the first item of an enum has the value 0. The second has the value 1, and so on.

// To get the integer value from an item, you must explicitly convert the item to an int:

// Example
enum Months
{
  January,    // 0
  February,   // 1
  March,      // 2
  April,      // 3
  May,        // 4
  June,       // 5
  July        // 6
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum);
}
// 3

// You can also assign your own enum values, and the next items will update their numbers accordingly:
enum Months
{
  January,    // 0
  February,   // 1
  March=6,    // 6
  April,      // 7
  May,        // 8
  June,       // 9
  July        // 10
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum);
}
 // 7

 == Enum in a Switch Statement == 

 // Enums are often used in switch statements to check for corresponding values:
 // example 

 enum Level 
{
  Low,
  Medium,
  High
}

static void Main(string[] args) 
{
  Level myVar = Level.Medium;
  switch(myVar) 
  {
    case Level.Low:
      Console.WriteLine("Low level");
      break;
    case Level.Medium:
       Console.WriteLine("Medium level");
      break;
    case Level.High:
      Console.WriteLine("High level");
      break;
  }
}

// Medium level

== C# Files == 

 // The File class from the System.IO namespace, allows us to work with files:

 // example 

using System.IO;  // include the System.IO namespace

File.SomeFileMethod();  // use the file class with methods

 // The File class has many useful methods for creating and getting information about files. For example:
 Method	        Description
AppendText()	Appends text at the end of an existing file
Copy()	        Copies a file
Create()	    Creates or overwrites a file
Delete()	    Deletes a file
Exists()	    Tests whether the file exists
ReadAllText()	Reads the contents of a file
Replace()	    Replaces the contents of a file with the contents of another file
WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

// For a full list of File methods, go to Microsoft .Net File Class Reference.

// Write To a File and Read It
 // In the following example, we use the WriteAllText() method to create a file named "filename.txt" and write some content to it.
// Then we use the ReadAllText() method to read the contents of the file:

// example 
using System.IO;  // include the System.IO namespace

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content

// Hello World!

 == C# Exceptions - Try..Catch == 
 // C# Exceptions
// When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
// When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).

// C# try and catch
// The try statement allows you to define a block of code to be tested for errors while it is being executed.
// The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
// The try and catch keywords come in pairs:
// Syntax
try 
{
  //  Block of code to try
}
catch (Exception e)
{
  //  Block of code to handle errors
}

// Consider the following example, where we create an array of three integers:

 // This will generate an error, because myNumbers[10] does not exist.

int[] myNumbers = {1, 2, 3};
Console.WriteLine(myNumbers[10]); // error!

// The error message will be something like this:

// System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

// If an error occurs, we can use try...catch to catch the error and execute some code to handle it.

// In the following example, we use the variable inside the catch block (e) together with the built-in Message property, which outputs a message that describes the exception:
// Example
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}
// Index was outside the bounds of the array.

// You can also output your own error message:

try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}

// Something went wrong.

// Finally
// The finally statement lets you execute code, after try...catch, regardless of the result:

// Example
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}
finally
{
  Console.WriteLine("The 'try catch' is finished.");
}
// The output will be:  Something went wrong. The 'try catch' is finished.

// The throw keyword
// The throw statement allows you to create a custom error.

// The throw statement is used together with an exception class. There are many exception classes available in C#:
// ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:

// Example 
static void checkAge(int age)
{
  if (age < 18)
  {
    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
  }
  else
  {
    Console.WriteLine("Access granted - You are old enough!");
  }
}

static void Main(string[] args)
{
  checkAge(15);
}
// The error message displayed in the program will be: 
// System.ArithmeticException: 'Access denied - You must be at least 18 years old.'

// If age was 20, you would not get an exception: 

// example
checkAge(20);
// output Access granted - You are old enough!
