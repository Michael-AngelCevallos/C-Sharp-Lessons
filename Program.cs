using System;
using System.Diagnostics;
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
            double x;
            double y;
            double result;
            Console.WriteLine("Enter your first number : ");
            x = Convert.ToDouble(Console.ReadLine()); // 5. Need to convert users input to double
            Console.WriteLine("Enter your second number : ");
            y = Convert.ToDouble(Console.ReadLine());
            

        }
        // IMPORTANT <==== METHOD NEEDS TO BE INVOKED OUTSIDE MAIN METHOD(bracket above this comment is the end of the main method)
        static double Multiply(double x, double y){ // 1. start method, needs to return 'double' state that after static

            double z = x * y; // 2. make a variable (z) to take in both variables(x,y) in order to multiply
            return z; // 3. state your return statement







        }
        
        
        
        }
        
    }

    



