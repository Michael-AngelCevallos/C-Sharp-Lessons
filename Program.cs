﻿using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Security;
using System.Threading.Channels;

namespace C_Sharp_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Log use Console.WriteLine()
            // Console.WriteLine("I like pizza");


            // Console Input 
            // Console.WriteLine("How Old Are You?");
            // string input = Console.ReadLine();
            // Console.WriteLine($"You are {input} years old!");



            //============================================================================================================================================
            // How To Format Output <----------------------------------------------------------------------------------
            // Console.Write("Hey"); // Console.Write will not hit enter key after declaration
            // Console.WriteLine(
            //     "Hey is on the same line as this one"); // Console.Writeline Will Hit Enter key after Declaration



            //===========================================================================================================================================

            // Auto generate Console.Writeline ( c + w + tab)<---------------------------------------------------------
            // Console.WriteLine();





            //===========================================================================================================================================
            // Console Escape Sequences <-------------------------------------------------------------------------------
            // Console.WriteLine("\tMike Cevallos"); // returns Mike Cevallos, Tabbed in (\t)
            //
            // Console.WriteLine("Mike\bCevallos"); // returns MikCevallos, uses backspace(\b)
            //
            // Console.WriteLine("Mike\nCevallos"); // returns Mike (new line) Cevallos
            //
            // // Variables in C#
            // // 2 steps Declaration and Initialization
            //
            // //integers
            // int x; // this is declaration of a variable
            // x = 123; // initialization of the variable
            //
            // //together would be 
            // int y = 321;
            //
            // // Adding using variable
            // int z = x + y;
            //
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);





            //===========================================================================================================================================
            // Display Message with String <---------------------------------------------------------------------------

            // int age = 29; // Integer(int) -Whole Number
            // Console.WriteLine("My age is " + age);
            //
            // double height = 68.5; // Double(decimal number) - Decimal Number
            // Console.WriteLine("My height is " + height + "in");
            //
            // bool on = true; // Boolean(bool)- True/False
            // Console.WriteLine("Is that Light On? " + on);
            //
            // char symbol = '@'; // Character(char)- Displays any ONE character, must be wrapped in SINGLE QUOTE
            // Console.WriteLine("My Email is michaelcevallos94" + symbol + "yahoo.com");
            //
            // String name = "YO My Name is Mike"; // String(String)- used for sentences, MUST USE DOUBLE QUOTES IN C#
            // Console.WriteLine(name);
            //
            // // ADD two variable together
            // String userName = symbol + name;
            // Console.WriteLine(userName);




            //===========================================================================================================================================
            //Constants- Lesson ( Using keyword const) <---------------------------------------------------------------
            //          Constants are immutable values which are known at compile time and
            //          do not change during the life of the program

            // const double pi = 3.14159;
            // // pi = 420; // DOES NOT WORK BECAUSE pi IS CONST IN ABOVE
            // // VARIABLE
            //
            // Console.WriteLine(pi);






            //===========================================================================================================================================
            // TYPE CASTING - Converting a Value to a Different Data Type <---------------------------------------------
            //                Useful when we accept User Input
            //                Different Data types can do different things  

            // double a = 2.34;
            // int b = Convert.ToInt32(a); // Convert.ToInt32() - is a method we use to convert double to int
            // Console.WriteLine(b);
            //
            // //display data type (.GetType())
            // Console.WriteLine(a.GetType());
            // Console.WriteLine(b.GetType());
            //
            // int c = 123;
            // double d = Convert.ToDouble(c);
            // Console.WriteLine(d.GetType()); // returns double
            //
            // int e = 321;
            // String f = Convert.ToString(e);
            // Console.WriteLine(f);
            //
            // String g = "$";
            // char h = Convert.ToChar(g);
            // Console.WriteLine(h);

            // String i = "true";
            // bool j = Convert.ToBoolean(i);
            // Console.WriteLine(j);


            //Create Variables to hold and store values 
            // Console.WriteLine("What is Your First Name?"); // Asks user in terminal
            // String name1 = Console.ReadLine(); // takes in users input for variable name1
            //
            // Console.WriteLine("How old are you?"); // Asks user in terminal
            // int age1 = Convert.ToInt32(Console.ReadLine()); 
            //
            // Console.WriteLine("Hello my name is " + name1 + " ,and I am " + age1 + " years old."); // Returns Hello {users input}





            //===========================================================================================================================================
            // Basic Arithmetic Lesson <--------------------------------------------------------------------------------

            // int friends = 5;
            // friends = friends + 1; // returns 6
            // // friends = friends + 2;// returns 8
            //
            // // += shortcut (same as above but shorter version)
            // friends += 2; // returns 8
            // Console.WriteLine(friends);
            //
            //
            //
            // // Increment/Decrement examples
            //
            // int friends2 = 5;
            //
            // //these all do the same thing
            // // friends2 = friends2 + 1;
            // // friends2 += 1;
            // friends2++;
            // Console.WriteLine(friends2);
            //
            // //Multiplication Example
            // int friends3 = 5;
            // // friends3 = friends3 * 2; // returns 10
            // friends3 *= 2; // return s 10
            // Console.WriteLine(friends3);
            //
            // //Division Example
            // int friends4 = 6;
            // // friends4 = friends4 / 2;
            // friends4 /= 2;
            // Console.WriteLine(friends4);
            //
            // // Module Operator (%) // lets you know if your number is whole or decimal number
            // int remainder = 25 % 2;
            // Console.WriteLine(remainder);



            //==========================================================================================================================================
            // Math Class Examples <-------------------------------------------------------------------------------

            // double t = 3.5;
            // double p = 5;
            //
            // double pow = Math.Pow(t, 2); // Math.Pow (Exponents) -  (first value is base number, second is exponent)
            // Console.WriteLine(pow); // returns 12.25
            //
            // double sqrt = Math.Sqrt(t); // Math.Sqrt - Returns sqrt of number
            // Console.WriteLine(sqrt); // returns 1.870828
            //
            // double abs = Math.Abs(t); // Math.Abs (Absolute Value) - returns positive version of number
            // Console.WriteLine(abs); // returns 3
            //
            // double round = Math.Round(t); // Math.Round -  Rounds Number( Up or Down Based on decimal)
            // Console.WriteLine(round); // returns 4
            //
            // double ceil = Math.Ceiling(t); // Math.Ceiling - Rounds Number Up No matter What the decimal is
            // Console.WriteLine(ceil); // returns 4
            //
            // double floor = Math.Floor(t); // Math.Floor - Rounds number Down no matter what  the decimal is 
            // Console.WriteLine(floor); // returns 3
            //
            // double max = Math.Max(t, p); // Math.Max - Returns highest number in list of numbers
            // Console.WriteLine(max); // returns 5
            //
            // double min = Math.Min(t, p); // Math.Min - returns lowest number in list of numbers
            // Console.WriteLine(min); //  returns 3.5





            //===========================================================================================================================================
            // Generate Random NUMBERS <-------------------------------------------------------------------------------

            // intiate Random Object
            // Random random = new Random();
            //
            // int dice = random.Next(1, 7); // Sets Range between 1 and 6
            // Console.WriteLine(dice);
            //
            //
            // int highDice = random.Next(1, 7) + 100; // Returns number between 101 -106
            // Console.WriteLine(highDice);
            //
            // // NextDouble - returns decimal number
            //
            // double nextDouble = random.NextDouble();
            // Console.WriteLine(nextDouble); // returns decimal
            //
            // // Roll Three Dice 
            //
            // int dice1 = random.Next(1, 7);
            // int dice2 = random.Next(1, 7);
            // int dice3 = random.Next(1, 7);
            // int all = dice1 + dice2 + dice3;
            //
            // Console.WriteLine("Your first roll is " + dice1);
            // Console.WriteLine("Your Second Roll is " + dice2);
            // Console.WriteLine("Your Third and Final Roll is " + dice3);
            // Console.WriteLine("Your Total Number is " + all);

            //===========================================================================================================================================
            // Hypotenuse Calculator <---------------------------------------------------------------------------------
            // Console.WriteLine("Enter Side A: ");
            // double sideA = (Convert.ToDouble(Console.ReadLine()));
            //
            // Console.WriteLine("Enter Side B: ");
            // double sideB = (Convert.ToDouble(Console.ReadLine()));
            //
            //
            // double sideC = Math.Sqrt(sideA * sideA) + (sideB + sideB);
            //
            // Console.WriteLine("Your Hypotenuse is: " + sideC + "in"); // returns 40







            // String Methods <===========================================================================================================================

            // String fullName = "Mike Cevallos";
            //
            //
            // String upperCase = fullName.ToUpper(); // ToUpper() - returns all letters UPPER-CASED
            // Console.WriteLine(upperCase);
            //
            //
            // String lowerCase = fullName.ToLower(); // ToLower() - returns all letters in string lower-cased
            // Console.WriteLine(lowerCase);
            //
            // Console.WriteLine(fullName);
            //
            //
            // // .Replace (Replaces an old value within string with new)
            // String phoneNumber = "123-456-7899";
            //
            // phoneNumber = phoneNumber.Replace("-", ""); // Replaces an old value within string with new
            // Console.WriteLine(phoneNumber); // returns 1234567899
            //
            // //.Insert () (inserts into a string( uses 2 parameters))
            // String userName1 = fullName.Insert(0, "@");
            // Console.WriteLine(userName1); // returns @Mike Cevallos
            //
            //
            // //.Length () displays length of string( including spaces)
            // Console.WriteLine(userName1.Length); // returns 14
            //
            // // SubStrings ( returns parts of string( first num in param is where to start, second is the length of that string)
            // String firstName = fullName.Substring(0, 4); // return Mike
            // String lastName = fullName.Substring(5, 8); // returns Cevallos
            //
            // Console.WriteLine(firstName);
            // Console.WriteLine(lastName);


            //IF STATEMENTS <=============================================================================================================================

            // Console.WriteLine("Please enter your age: ");
            // int age1 = Convert.ToInt32(Console.ReadLine());
            //
            // if (age1 >= 18)
            // {
            //     Console.WriteLine("Congratulations! Your An Adult");
            // }
            // else
            // {
            //     Console.WriteLine("Get back in line, your Too Young!");
            // }
            //
            // //With Else If Statement
            // Console.WriteLine("Please enter your age: ");
            // int age2 = Convert.ToInt32(Console.ReadLine());
            //
            // if (age2 < 0)
            // {
            //     Console.WriteLine("You Haven't Been Born Yet");
            // }else if(age2 >= 18) 
            // {
            //     Console.WriteLine("Congratulations! Your An Adult");
            // }
            // else
            // {
            //     Console.WriteLine("Get back in line, your Too Young!");
            // }
            //
            // Console.WriteLine("Please enter your name: ");
            // String name1 = Console.ReadLine();
            //
            //
            // if (name == "") // returned an empty string
            // {
            //     Console.WriteLine("You Didn't Enter anything!");
            // }
            // else
            // {
            //     Console.WriteLine("Hello " + name1 + "!");
            // }
            //

            //============================================================================================================================================
            // SWITCH Statements - an efficient alternative to many if else statemenets 

            // Console.WriteLine("What day is today?");
            // String day = Console.ReadLine();
            //
            // switch (day)
            // {
            //     case "Monday":
            //         Console.WriteLine("IT's Mad Monday's!");
            //         break;
            //     case "Tuesday":
            //         Console.WriteLine("IT's Taco Tuesday!");
            //         break;
            //     case "Wednesday":
            //         Console.WriteLine("IT's Wack Wednesday's");
            //         break;
            //     case "Thursday":
            //         Console.WriteLine("IT's Thirsty Thursdays!");
            //         break;
            //     case "Friday":
            //         Console.WriteLine("IT's Freaky Friday's!");
            //         break;
            //     case "Saturday":
            //         Console.WriteLine("IT's Sick Saturday's!");
            //         break;
            //     case "Sunday":
            //         Console.WriteLine("IT's Sunday! Get Ready For Church, BBQ's, AND FOOTBALL!");
            //         break;
            //     default:
            //         Console.WriteLine(day + " is not a day of the week!");
            //         break;
            // }



            // If Statement Equivalent of above switch statement
            // if (day == "Monday")
            // {
            //     Console.WriteLine("It's Monday");
            // } 
            // else if (day == "Tuesday") {
            //     Console.WriteLine("It's Tuesday!");
            //
            // } 
            // else if (day == "Wednesday") {
            //     Console.WriteLine("It's Wednesday!");
            //
            // }
            // else if (day == "Thursday") {
            //     Console.WriteLine("It's Thursday");
            //
            // } 
            // else if (day == "Friday") {
            //     Console.WriteLine("It's Friday");
            // } else{
            //     Console.WriteLine("Invalid Answer,Try again");
            // }



            //===========================================================================================================================================
            // LOGICAL OPERATORS - can be used to check if more than one condition is true/false

            // && (AND) - both conditions need to be true to follow through
            // || (OR)  - only 1 condition needs to be true to foolow through

            //         Console.WriteLine("Whats the temperature outside: ");
            //         double temp = Convert.ToDouble(Console.ReadLine());
            //
            //
            //         if (temp >= 70 && temp <= 80) // Both conditions must be true to return message, otherwise it will skip
            //         {
            //             Console.WriteLine("Weathers is great, wear shorts and a t-shirt but bring a blanket");
            //         } else if (temp <= -50 || temp >= -50) // only one needs to be true to continue
            //         {
            //             Console.WriteLine("Do NOT go Outside , it is too COLD!");
            //         
            // }


            //===========================================================================================================================================
            // While Loop - repeats code if condition remains true

            // Console.WriteLine("Enter your name : ");
            // String name2 = "";
            //
            // while (name2 == "")
            // {
            //     Console.WriteLine("Help Im stuck in a loop");
            // }





            //===============================================================================================================================================

            // For loop - repeats some code a FINITE amount of times

            // for(int i = 0; i < 10; i += 1) // First tells you what nuymber to start at, Second gives logic, third specifies increment
            // {
            //     Console.WriteLine(i);  // counts from 0 -9
            // }

            // for (int i = 1; i <= 50; i  += 4) // multiplies 
            // {
            //     Console.WriteLine(i * 2);
            // }


            //================================================================================================================================================
            // Nested Loops - loops insid of other loops. Used alot in sorting algorithims

            // Console.WriteLine("How many rows?");
            // int rows = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("How many columns?");
            // int columns = Convert.ToInt32(Console.ReadLine());
            //
            // Console.WriteLine("What symbol: ");
            // char symbol1 = Convert.ToChar(Console.ReadLine());



            // Multiplies 2 numbers from user input and returns the symbol that many times
            // for (int i = 0; i < rows; i++)
            // {
            //     for (int j = 0; j < columns; j++)
            //     {
            //         Console.WriteLine(symbol1);
            //     }
            //     Console.WriteLine();
            // }
            //

            //==============================================================================================================================================

            //Using Random Object ( Random random = new Random() )
            // GUESS A NUMBER GAME WITH LOOP FOR PROGRAM ! <--------------------------------------------

            // bool playAgain = true;
            // int min1 = 1;
            // int max1 = 100;
            //
            // int guess;
            // int number;
            // int guesses;
            // String response;
            //
            // while (playAgain)
            // {
            //     guess = 0;
            //     guesses = 0;
            //     response = "";
            //     number = random.Next(min1, max1);
            //
            //     while (guess != number)
            //     {
            //         Console.WriteLine("Guess A number between " + min1 + " and " + max1 + ": ");
            //         guess = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine("Guess: " + guess);
            //
            //         if (guess > number)
            //         {
            //             Console.WriteLine(guess + " is to high!");
            //         }
            //         else if (guess < number)
            //         {
            //             Console.WriteLine(guess + " is to low!");
            //         }
            //
            //         guesses++;
            //         {
            //             Console.WriteLine("Number: " + number);
            //             Console.WriteLine("YOU WIN!");
            //             Console.WriteLine("Guesses " + guesses);
            //
            //             Console.WriteLine("Would You Like TO Play Again (Y/N): ");
            //             response = Console.ReadLine();
            //             response = response.ToUpper();
            //
            //             if (response == "Y")
            //             {
            //                 playAgain = true;
            //             }
            //             else
            //             {
            //                 playAgain = false;
            //             }
            //         }
            //         Console.WriteLine("Thank for playing!");
            //     }
            // }



            //================================================================================================================================================
            // Rock, Paper, Scissors Game 

            //     Random
            //         random1 = new Random(); // Random object - generates Random number for Computers Choice <-------------
            //
            //     bool playAgain1 = true; // This will allow user to opt out of playing again (if false)
            //     String player;
            //     String computer;
            //     String answer;
            //
            //     while (playAgain1) // assumes playAgain IS true
            //     {
            //         player = "";
            //         computer = "";
            //         answer = "";
            //
            //         while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //         {
            //             Console.WriteLine("Enter ROCK, PAPER, OR SCISSORS!!!!!! :  ");
            //             player = Console.ReadLine(); // STORES USERS INPUT
            //             player = player.ToUpper(); // Will return players choice in uppercase 
            //         }
            //
            //
            //         //     Console.WriteLine(player); // prints out users choice of rock, paper ,or scissors
            //         // }
            //
            //
            //
            //         switch (random1.Next(1, 4))
            //         {
            //             case 1:
            //                 computer = "ROCK";
            //                 break;
            //             case 2:
            //                 computer = "PAPER";
            //                 break;
            //             case 3:
            //                 computer = "SCISSORS";
            //                 break;
            //         }
            //
            //         Console.WriteLine("Player: " + player);
            //         Console.WriteLine("Computer: " + computer);
            //
            //         switch (player)
            //         {
            //             case "ROCK":
            //                 if (computer == "ROCK")
            //                 {
            //                     Console.WriteLine("It's A Draw");
            //                 }
            //                 else if (computer == "PAPER")
            //                 {
            //                     Console.WriteLine("You lose!");
            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("You Win!");
            //                 }
            //
            //                 break;
            //
            //             case "PAPER":
            //                 if (computer == "ROCK")
            //                 {
            //                     Console.WriteLine("You Lose!");
            //                 }
            //                 else if (computer == "PAPER")
            //                 {
            //                     Console.WriteLine("Its a Draw!");
            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("You Win!");
            //                 }
            //
            //                 break;
            //
            //             case "SCISSORS":
            //                 if (computer == "ROCK")
            //                 {
            //                     Console.WriteLine("You Win!");
            //                 }
            //                 else if (computer == "PAPER")
            //                 {
            //                     Console.WriteLine("You lose!");
            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("Its a Draw!");
            //                 }
            //
            //                 break;
            //         }
            //         
            //         Console.WriteLine("Would you like to play again? (Y/N): ");
            //         answer = Console.ReadLine();
            //         answer = answer.ToUpper();
            //         if (answer == "Y")
            //         {
            //             playAgain1 = true;
            //         }
            //         else
            //         {
            //             playAgain1 = false;
            //         }
            //     }
            //     Console.WriteLine("GoodBye!");
            // }

            //=====================================================================================================================================================
            // CALCULATOR PROGRAM

            // 1st - : START BY WRITING A STATEMENT TO LET USER KNOW WHAT IS BEING RUN
            // Console.WriteLine("-----------------------------------"); // added dashes to console to stand out
            // Console.WriteLine("CALCULATOR PROGRAM"); // WRITES THIS TEXT TO TERMINAL AT THE BEGINNING OF THE RUN
            // Console.WriteLine("-----------------------------------"); // added for visual aesthetics
            //
            //
            //
            // do
            // {
            //
            //
            //     // 2nd - START THINKING ABOUT VARIABLES NEEDED FOR PROGRAM AND DECLARE THEM
            //     double num1 = 0; // sets sequence to zero
            //     double num2 = 0;
            //     double result = 0; // This Variable is used to take in users selection of operation
            //     bool playAgain2 = true;
            //     String answer1;
            //
            //
            //
            //     // 3rd - Get USERS 1st input and store it
            //     Console.WriteLine("Enter Number 1: "); // ask for users first number
            //     num1 = Convert.ToDouble(Console.ReadLine()); // Stores Users first number
            //
            //     //4th - Get Users 2nd input and Store it
            //     Console.WriteLine("Enter Number 2: "); // ask 
            //     num2 = Convert.ToDouble(Console.ReadLine()); // stores it
            //
            //     // 5th - Enter your numbers prompt: 
            //     Console.WriteLine("Enter your numbers : ");
            //
            //
            //     // 6th - Give USER Options with what to do with numbers in CONSOLE
            //     Console.WriteLine();
            //     Console.WriteLine("+ Add: ");
            //     Console.WriteLine("- Subtract: ");
            //     Console.WriteLine("* Multiply: ");
            //     Console.WriteLine("/ Divide: ");
            //
            //     // 7th - Make SWITCH Statement Concept to handle choices
            //     switch (Console.ReadLine())
            //     {
            //         case "+"
            //             : // <---- Search for the Addition operator in the users input (from cw above) <--------------------------------------------------------
            //             result = num1 + num2; // Gives the order to ADD the USERS INPUT
            //             Console.WriteLine($"Your answer of : {num1} + {num2} =  " +
            //                               result); // Re-iterates the the calculation the was selected by the USER
            //             break;
            //         case "-":
            //             result = num1 - num2; // Gives the order to SUBTRACT the USERS input
            //             Console.WriteLine($"Your answer of : {num1} - {num2} =  " +
            //                               result); // Re-iterates the the calculation the was selected by the USER
            //             break;
            //         case "*":
            //             result = num1 * num2; // Gives the order to MULTIPlY the USERS input 
            //             Console.WriteLine($"Your answer of : {num1} * {num2} =  " +
            //                               result); // Re-iterates the the calculation the was selected by the USER
            //             break;
            //         case "/":
            //             result = num1 / num2; // Gives the order to DIVIDE the USERS input
            //             Console.WriteLine($"Your answer of : {num1} / {num2} =  " +
            //                               result); // Returns Answer & CW of The Operation that was selected USER
            //             break;
            //
            //
            //     }
            //
            //
            //     Console.WriteLine("Play Again?: Enter -> (Y/N)");

            // } while (Console.ReadLine().ToUpper() == "Y");


            //==================================================================================================================================================
            // ARRAYS ------ A VARIABLE THAT CAN STORE MULTIPLE VALUES (ARRAYS HAVE A FIXED SIZE!!!!!


            // String[] cars = { "Cadillac", "Chevy", "Ferrari" };


            // Console.WriteLine(cars); // <----- WILL RETURN DATA TYPE OR (System.String[]) to console
            //
            // Console.WriteLine(cars[0]); // returns Cadillac
            // Console.WriteLine(cars[1]); // returns Chevy
            // Console.WriteLine(cars[2]); // returns Ferrari
            //
            // // Change value of an index (Change Ferrari to Tesla)
            // cars[2] = "Tesla";
            // Console.WriteLine(cars[2]); // returns Tesla


            // Return all values of array with for loop
            // for (int i = 0; i < cars.Length; i++)
            // {
            //     Console.WriteLine(cars[i]); // returns     Cadillac 
            // }                               //             Chevy 
            //                                 //             Ferrari 
            //
            //                                 Console.WriteLine();// usede for a space in terminal
            // //Declare A FIXED ARRAY
            // // String[] cars1 = { "Chevy", "Lambo", "Jeep" };
            // String[] cars1 = new string[3]; // Fixed number
            //
            // // Add names of cars to each index 
            // cars1[0] = "Jeep";
            // cars1[1] = "Lambo";
            // cars1[2] = "Tesla";
            //
            // // loop through array to name all cars in cars1 array
            // for (int j = 0; j < cars1.Length; j++)
            // {
            //     Console.WriteLine(cars1[j]);
            // }


            //==================================================================================================================================================

            // FOR EACH LOOP ---- SIMPLER WAY TO ITERATE OVER AN ARRAY

            // HOWEVER LESS FLEXIBLE THEN REG FOR LOOP


            // String[] names = { "Mike", "Alex", "Jovan", "Ares" };
            //
            //
            // foreach (String name in names) // name 'data type' then 'single version of variable' the 'in' then variable
            // {
            //     Console.WriteLine(name);
            // }


            //===================================================================================================================================================

            //     // METHOD --------- performs a section of code whenever it is called or 'invoked'
            //     //                  benefit - lets us re-use code without writing it multiple times
            //     
            //     //Variables We could chose to USE or NOT use ( NEEDED TO BE STATED IN THE MAIN METHOD)
            //     String name = "Bro";
            //     int age = 29;
            //     
            //     
            //     //invoked method singHappyBirthday, allows us to call multiple sec of code (such as happy birthday lyrics below)
            //     singHappyBirthday(name, age); // invoke/call method(or function) outside, add parameter syou want to use in the invocation
            //
            // }
            //
            // static void singHappyBirthday(String name, int age) // this invokes a method from above main method, must be declared outside main brackets
            // {
            //     Console.WriteLine("Happy birthday to you");
            //     Console.WriteLine("Happy birthday to you");
            //     Console.WriteLine("Happy birthday to you");
            //     Console.WriteLine("Happy birthday DEAR " + name + "!");
            //     Console.WriteLine("Happy birthday to you");
            //     Console.WriteLine("Congratulations! Your " + age + ", years old!");
            // }

            //======================================================================================================================================================
            // Return - returns data back to the place where the method is invoked

            // 4. add variables x and y 
            //     double x;
            //     double y;
            //     double result;
            //     Console.WriteLine("Enter your first number : ");
            //     x = Convert.ToDouble(Console.ReadLine()); // 5. Need to convert users input to double
            //     Console.WriteLine("Enter your second number : ");
            //     y = Convert.ToDouble(Console.ReadLine());
            //
            //     result = Multiply(x,y); // 6. invoke Multiply Method, add in parameters
            //
            //     Console.WriteLine("Your answer is " + result);
            //
            //
            // }
            // // IMPORTANT <==== METHOD NEEDS TO BE INVOKED OUTSIDE MAIN METHOD(bracket above this comment is the end of the main method)
            // static double Multiply(double x, double y)
            // {
            //     // 1. start method, needs to return 'double' state that after static
            //
            //     double z = x * y; // 2. make a variable (z) to take in both variables(x,y) in order to multiply
            //     return z; // 3. state your return statement

//=====================================================================================================

// Method Overloading - methods share SAME NAME, But DIFFERENT PARAMETERS
//                      name + parameters = signature
//                      methods must have a unique signature
            //
            // // 1. State variable in MAIN Method
            // double total;
            //
            //
            // // 2. state what total takes in ( now Multiply will work with 2 or 3 parameters when called)
            // total = Multiply(2,3,4);
            // // total = Multiply(4, 5);
            //
            //
            // Console.WriteLine(total);
            //
            //
            //     }
            //
            //     // 3. make Multiply Method outside main
            //     static double Multiply(double a, double b)
            //     {
            //         return a * b;
            //     }
            //     
            //     // 4. make multiply method that takes in 3 parameters
            //     static double Multiply(double a, double b, double c)
            //     {
            //         return a * b * c;
            //     }


            //====================================================================================================

            // Param keyword -- a method parameter that takes in a variable number of arguments
            // - The parameter type must be single - dimensional array
            // ALLOWS US to call a method with various amounts of variable within ONE method  


            //===========>>   Example make an Online Store, with a Method to Checkout(Which adds customers
            // prices) and returns the total, then tell customer you have to pay the specific total

            //.1 Make a variable within the main  that will add all prices together
            // this variable will taken a method called CheckOut which we will call later
            //            double total = CheckOut(3.99, 5.75, 15);
            //
            //            // 6. Lastly retutn the total to the console
            //            Console.WriteLine(total);
            //
            // }
            //
            // // 2. Make Checkout Method With PARAMS keyword in parameter
            // static double CheckOut(params double[] prices)
            // {
            //     // 3. Make a local variable to iterate through (total)
            //     double total = 0; // starts the sequence at 0
            //     // 4. Use foreach loop to iterate over each element in array
            //     foreach (double price in prices)
            //     {
            //         total = total + price;
            //     }
            //
            //     // 5. return total
            //     return total;
            // }
//=======================================================================================================
            // // Exception Handling - errors that occur during an execution
            //
            // // TYPES OF EXCEPTIONS
            //
            // // try = try some code that is considered "dangerous"
            // // catch = catches and handles exceptions when they occur
            // // finally = ALWAYS executes regardless if exception is caught or not
            //
            // // Example- a small program where we will ask user to type in two numbers, divide those numbers, then display the result. So what if the user types in something that isn t a number?
            //
            // // 1. make variables needed to divide ( 2 numbers, and a variable for result)
            // int x; // takes in users first number
            // int y; //  takes in users second number
            // int result; // takes in answer
            //
            // // 6. Start EXCEPTION HANDLING by Wrapping in a try/ catch 
            // try
            // {
            //
            //     // 2. Start setting up for user in put for first number
            //     Console.WriteLine("What is Your First Number: ");
            //     x = Convert.ToInt32(Console.ReadLine()); // CONVERT TO will accept the users input as a double
            //
            //     // 3. Start setting up for second number
            //     Console.WriteLine("What is Your Second Number : ");
            //     y = Convert.ToInt32(Console.ReadLine());
            //
            //     // 4. State logic for dividing user numbers
            //     result = x / y;
            //
            //     // 5. Return the answer to the console
            //     Console.WriteLine("Your answer for " + x + "/" + y + " is " + result);
            //
            //     // 7. Add a ctach that will throw a message if data type isnt correct (FormatException e)
            // }
            // catch (FormatException
            //        e) // 8. write in a FormatException(throws for different data types) parameter with letter e
            // {
            //     Console.WriteLine("Write ONLY Numbers!!!"); // 9. return 
            // }
            // catch (DivideByZeroException e) // 10 . Catch a divide by Zero (WILL ONLY WORK WITH INTEGER DATA TYPE!!!!)
            // {
            //     Console.WriteLine("Cannot Divide By Zero!!");
            // }
            // catch (Exception e) // 11. Good practice to add a Catch All just in case we missed something
            // {
            //     Console.WriteLine("Something Went Wrong!");
            // }
            // finally // 12. Add a finally block to execute a message at the end no matter what
            // {
            //     Console.WriteLine("Thanks for Trying!");
            // }

//=====================================================================================================        
            // // CONDITIONAL OPERATORS - USED IN CONDITIONAL ASSIGNMENT DEPENDING IF CONDITION IS TRUE/FALSE
            //
            // // (condition) ? x : y
            //
            //
            // // 1. Make variables 
            // double temperature = 20;
            // // String message;
            // //
            // // // 2. Assign variable Message with a condition for temperature, add ?, then messages for true/false
            // // message = (temperature >= 15) ? "It's Warm Outside" : "It's Cold Outside";
            // //
            // // // 3. Added write message to variable
            // // Console.WriteLine(message);
            //
            //
            //
            //
            // // OPTIONAL One Liner -  can get rid of message variable and just add logic into CW
            // Console.WriteLine((temperature >= 15) ? "It's Warm Outside" : "It's Cold Outside");

            //================================================================================================

            // // STRING INTERPOLATION - ALLOWS US TO INSERT VARIABLES INTO A STRING LITERAL
            // //                        PRECEDE STRING LITERAL WITH $
            // //                        {} ARE PLACEHOLDERS
            //
            // // EXAMPLE - WE HAVE THREE VARIABLES FIRSTNAME, LASTNAME, AND AGE.
            //
            //
            // // 1. Make variables for firstname, lastname and age
            // String firstName = "Mike";
            // String lastName = "Cevallos";
            // int age = 29;
            //
            // // //  Normal Version ( WITHOUT String Literals)
            // // Console.WriteLine("Hello " + firstName + " " + lastName + ",");
            // // Console.WriteLine("You are " +  age + " years old.");
            //
            // // 2. Add String literals to message
            // // -  Start With CW , Add $, place variables in {}
            // Console.WriteLine($"Hello {firstName} {lastName}! You are {age} years old!");
            //
            // // SIDE NOTE -  If you add a number after your variable it will add spaces in the console message 
            // //example for age (Positive numbers move the spaces to the left) -
            // Console.WriteLine($"Hello {firstName} {lastName}! You are {age,5} years old!");
            //
            // // Can also add negative number to move spaces right
            // Console.WriteLine($"Hello {firstName} {lastName}! You are {age,-5} years old!");

            //==================================================================================================

            // MULTI-DIMENSIONAL ARRAYS - ARRAY OF ARRAYS

            // // 1. Make Array Variables
            // String[] chevy = { "Silverado", "Trailblazer", "Tahoe" };
            // String[] cadillac = { "Escalade", "Deville", "CTS" };
            // String[] ford = { "Bronco", "F-150", "Excursion" };
            //
            // // 2. Make 2 Dimensional Array - List Data Type Of what your storing (String[]), then add all the above to one array
            // String[,] parkingLot = {{ "Silverado", "Trailblazer", "Tahoe" }, 
            //                         { "Escalade", "Deville", "CTS" },
            //                         { "Bronco", "F-150", "Excursion" }
            //                          };
            //
            // // 3. Change the value of "Bronco" to "Fusion" within parkingLot by :
            // parkingLot[2, 0] = "Fusion";
            //
            // // // 4. Use a foreach loop to loop through everything
            // // foreach (String car in parkingLot)
            // // {
            // //     Console.WriteLine(car); //returns as a list with one item per row
            // // }
            //
            // // 5. Nested Loop Version
            // for (int i = 0; i < parkingLot.GetLength(0); i++)
            // {
            //     for (int j = 0; j < parkingLot.GetLength(1); j++)
            //     {
            //         Console.WriteLine(parkingLot[i, j] + " ");
            //     }
            //
            //     Console.WriteLine();
            // }


//===================================================================================================        // PART OF CLASSES LESSON FROM BELOW
            // 4. Call on messages class in main class with each method
            // Messages.Hello();
            // Messages.Waiting();
            // Messages.Goodbye();


            //=================================================================================================
            // OBJECTS - AN INSTANCE OF A CLASS
            // A CLASS CAN BE USED AS A BLUEPRINT TO CREATE OBJECTS (OOP)
            // OBJECTS CAN FIELDS AND METHODS (CHARACTERISTICS AND ACTIONS)

            // Example, look around you. you are surrounded by objects. Monitor, mouse , tv, printer. We can use code to mimic real world objects. The can have fields(characteristics- describes what an object has) and methods(actions- what an object can do).

            // Objective - we will be instianting human objects, but will need the help of a Human CLASS( this will be a blueprint to design fields and methods for the human objects)

            // ** IMPORTANT NOTE - YOU CAN MAKE THE HUMAN CLASS IN THIS SAME C FILE OR CREATE A NEW C FILE 

            // CLASSES MUST BE MADE OUTSIDE THE MAIN METHOD TO WORK <---------------

            //5. initiate a method from Human class
            // Start By Calling The class in Upper case and then lower case. then = new Human();
            // Human human1 = new Human();
            // Human human2 = new Human();
            // Human human3 = new Human();
            //
            // // 6. give human1 a name
            // human1.name = "Mike";
            // human1.age = 29;
            //
            // human2.name = "ALex";
            // human2.age = 27;
            //
            // human3.name = "Roman";
            // human3.age = 21;
            //
            // // 7. Call the method eat from human class
            // // Start with naming your object name (in this case human1) then . and name of method you want to call from the human class
            // human1.Eat();
            // human1.Age();
            //
            // human2.Eat();
            // human2.Age();
            //
            // human3.Eat();
            // human3.Age();


            //==================================================================================================         // CONSTRUCTORS - A SPECIAL METHOD WITHIN A CLASS
            // SAME NAME AS THE CLASS NAME
            // CAN BE USED TO ASSIGN ARGUMENTS TO FIELDS WHEN CREATING AN OBJECT

            // 1. create a constructor within the human class ( go to c file name Human)


            //2. Create initiation of Human object, Note that now since parameters were called in constructor( in human c file), they can now be stored in the instantiation 

            // Human human1 = new Human("Bobby", 35);
            // Human human2 = new Human("John", 32, "Mexican");
            //
            // human1.Sleep();
            // human2.Sleep();
            
            // CAR car1 = new CAR("Blue", 2017, "Chevy");
            // CAR car2 = new CAR("Orange", 2020, "Lamborghini");

            // car1.Car();
            // car2.Car();

            
 //=======================================================================================================================
 
            // STATIC - MODIFIER TO DECLARE A STATIC MEMBER, WHICH BELONGS TO THE CLASS ITSELF RATHER THAN TO ANY SPECIFIC OBJECT 

          
            // // 1. MAKE 2 CAR OBJECT INITIATIONS
            //
            // CAR car1 = new CAR("Blue", 1964, "Impala");
            // CAR car2 = new CAR("Black", 2002, "Cadillac");
            //
            // // Console.WriteLine(car1.numberOfCars);
            // // Console.WriteLine(car2.numberOfCars);
            //
            //
            // // 4. NOW ABOVE EXAMPLES WILL NOT WORK. YOU MUST CALL A STATIC VERSIONS (CLASS NAME + . + VARIABLE YOU WANT TO CALL)
            //
            // Console.WriteLine(CAR.numberOfCars); // RETURNS 2
            //
            // //6 . in order to invoke StartRace method(in CAR class) start with class name(CAR) + . + name of method(StartRace)
            // CAR.StartRace();

            
 //======================================================================================================================
 
            // OVERLOADED CONSTRUCTORS - TECHNIQUE TO CREATE MULTIPLE CONSTRUCTORS,
                                      // WITH A DIFFERENT SET OF PARAMETERS
                                      // NAME + PARAMETER = SIGNATURE

        //
        //
        // // 5. initiate 2 different pizza classes with different amounts of parameters
        //   Pizza pizza1 = new Pizza("White", "Pepporoni", true);
        //
        //   Pizza pizza2 = new Pizza("wheat",false);
        //
        // pizza1.WhatKindOfPizza();
        //
        // pizza2.WhatKindOfPizza();

        
//======================================================================================================================

        // INHERITANCE - 1 OR MORE CHILD RECEIVING FIELDS, METHODS, ETC. FROM A COMMON PARENT
            
        // Example: Kind of like how we inherit certain genes from our grandparents/parents. Parent Classes can have children classes. Lets create a Vehicle Class, that is not specific but just general vehicle, with One field .
        
        // 1. create vehicle class, with one field, outside main method (located below)
        
        // 7. instiate all vehicl child classes here

        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();
        
        // 8. ONCE CLASS OBJECT IS INSTIATED WE NOW CAN CALL CLASS METHODS
        car.Go();
        bicycle.Go();
        boat.Go();

        Console.WriteLine("The car has " + car.wheels);
        Console.WriteLine("The bicycle has " + bicycle.wheels);
        Console.WriteLine("The boat has " + boat.wheels);

        // 9. now specify each message retured for Go method to be specific for each class, by calling same method within each class below( outside main)

//==========================================================================================================================================================
        // Abstract Classes - MODIFIER THAT INDICATES MISSING COMPONENTS OR 







        }
    }
    
    // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ END OF MAIN METHOD (ABOVE) ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

    
    
    
    
    // -----> CREATE A CLASS WITHIN A SEPARATE C-SHARP FILE OR WITHIN SAME FILE
    // #1 - OPEN SOLUTION EXPLORER ( GO TO VIEW, SOLUTION EXPLORER, RIGHT -CLICK ON YOUR NAMESPACE, CLICK ADD, CLICK CLASS, CLICK CLASS, NAME IT MESSAGES 
    
    
    
 //======================================================================================================================   
    // 1. USED FOR OVERLOADED CONSTRUCTORS CLASS - Make a class named pizza
    // class Pizza
    // {
    //     // 2. Make variables for pizza class
    //     public String bread;
    //     public String topping;
    //     public bool xtraCheese;
    //     
    //     // 3. Make Constructor - add parameters
    //     public Pizza(String bread, String topping, bool xtraCheese)
    //     {
    //         this.bread = bread;
    //         this.topping = topping;
    //         this.xtraCheese = xtraCheese;
        // }
        
        // 4. lets say some one wants a pizza with no toppings, make a constructor named Pizza that does'nt take in a toppings parameter

        // public Pizza(String bread, bool xtraCheese)
        // {
        //     this.bread = bread;
        //     this.xtraCheese = xtraCheese;
        //     
        // }
        //
        // // Make a method that will return what your pizza has
        // public void WhatKindOfPizza()
        // {
        //     Console.WriteLine("Your pizza has " + bread + " bread, " + topping + " for the topping, and " + xtraCheese + " for extra cheese");
        // }
// }

//====================================================================================================
    // CLASSES - bundles of related code.
    //          Can be used as a blue print for OOP (Object Oriented Programming)

    // IMPORTANT NEW CLASSES MUST BE MADE OUTSIDE OTHER CLASSES. IN THIS EXAMPLE WE ARE MAKING A CLASS OUTSIDE THE MAIN CLASS

    // 1. Make a class Called Messages that will hold a bunch of messages that can be called later
    // static class Messages
    // {
    //     // 2. Create a few methods related to messages
    //     public static void Hello()
    //     {
    //         Console.WriteLine("Hello");
    //     }
    //     public static void Waiting()
    //     {
    //         Console.WriteLine("You Are Waiting...");
    //     }
    //     public static void Goodbye()
    //     {
    //         Console.WriteLine("Goodbye!");
    //     }

    
//========================================================================================================================
    
        // 1. USED FOR INHERITANCE LESSON - Make Parent Vehicle Class with one field ( TO MAKE CLASS TYPE 'PUBLIC CLASS NAME OF CLASS') NO PARENTHESIS FOR CLASS START  <------------

        public class Vehicle
        {
            // 1. add first FIELD(A VARIABLE of any type that is declared DIRECTLY in the CLASS) to class
            public int speed = 0;
            
            // 2. create a method, Go , that returns a message showing that the vehicle is going somewhere
                    // Start a Method -  public void + name of method
                    public void Go()
                    {
                        Console.WriteLine("The Vehicle is Now Moving!");
                    }
        }
        
        // 3. WE CAN INHERIT METHODS AND VARIABLES FROM ONE CLASS TO ANOTHER BY INPUTING A ':' IN THE NEW CLASS NAME + THE INHERITED CLASS NAME
        class Car : Vehicle // Car is the CHILD class to vehicle <------------
        {
            // 4. add additional varibles for the car class, like umber of wheels
            public int wheels = 4; // Now all car objects will automatically have 4 wheels
            
            // 9. 
            public void Go()
            {
                Console.WriteLine("The Car is Now Moving!");
            }
            
        }
        
        // 5. Make a bicycle class that inherits the parent Vehicle class
        class Bicycle : Vehicle
        {
            // 6. Make a wheels variable that defines the n umber of wheels for bicycle
            public int wheels = 2;
            
            // 9.
            public void Go()
            {
                Console.WriteLine("The Bicycle is Now Moving!");
            }
            
        }
        
        class Boat : Vehicle
        {
            // 6. Make a wheels variable that defines the n umber of wheels for bicycle
            public int wheels = 0;
            
            // 9. 
            public void Go()
            {
                Console.WriteLine("The Boat is Now Moving!");
            }
        }
        
        // 7. initiate the objects in the main class above 
    
//=====================================================================================================

               // USED FOR ABSTRACT CLASS


}








    
    

    



