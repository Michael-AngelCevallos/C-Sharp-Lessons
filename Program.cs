using System;

namespace C_Sharp_Lessons
{
    class Program
    {
        static void Main()
        {
            // Console Log use Console.WriteLine()
            Console.WriteLine("I like pizza");


            // Console Input 
            // Console.WriteLine("How Old Are You?");
            // string input = Console.ReadLine();
            // Console.WriteLine($"You are {input} years old!");


            // How To Format Output <----------------------------------------------------------------------------------
            Console.Write("Hey"); // Console.Write will not hit enter key after declaration
            Console.WriteLine("Hey is on the same line as this one"); // Console.Writeline Will Hit Enter key after Declaration

            
            
            
            // Auto generate Console.Writeline ( c + w + tab)<---------------------------------------------------------
            Console.WriteLine();

            
            
            // Console Escape Sequences <-------------------------------------------------------------------------------
            Console.WriteLine("\tMike Cevallos"); // returns Mike Cevallos, Tabbed in (\t)

            Console.WriteLine("Mike\bCevallos"); // returns MikCevallos, uses backspace(\b)

            Console.WriteLine("Mike\nCevallos"); // returns Mike (new line) Cevallos

            // Variables in C#
            // 2 steps Declaration and Initialization

            //integers
            int x; // this is declaration of a variable
            x = 123; // initialization of the variable

            //together would be 
            int y = 321;

            // Adding using variable
            int z = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Display Message with String <---------------------------------------------------------------------------

            int age = 29; // Integer(int) -Whole Number
            Console.WriteLine("My age is " + age);

            double height = 68.5; // Double(decimal number) - Decimal Number
            Console.WriteLine("My height is " + height + "in");

            bool on = true; // Boolean(bool)- True/False
            Console.WriteLine("Is that Light On? " + on);

            char symbol = '@'; // Character(char)- Displays any ONE character, must be wrapped in SINGLE QUOTE
            Console.WriteLine("My Email is michaelcevallos94" + symbol + "yahoo.com");

            String name = "YO My Name is Mike"; // String(String)- used for sentences, MUST USE DOUBLE QUOTES IN C#
            Console.WriteLine(name);

            // ADD two variable together
            String userName = symbol + name;
            Console.WriteLine(userName);


            //Constants- Lesson ( Using keyword const) <---------------------------------------------------------------
            //          Constants are immutable values which are known at compile time and
            //          do not change during the life of the program

            const double pi = 3.14159;
            // pi = 420; // DOES NOT WORK BECAUSE pi IS CONST IN ABOVE
            // VARIABLE

            Console.WriteLine(pi);

            // TYPE CASTING - Converting a Value to a Different Data Type <---------------------------------------------
            //                Useful when we accept User Input
            //                Different Data types can do different things  

            double a = 2.34;
            int b = Convert.ToInt32(a); // Convert.ToInt32() - is a method we use to convert double to int
            Console.WriteLine(b);

            //display data type (.GetType())
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c);
            Console.WriteLine(d.GetType()); // returns double

            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(f);

            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);

            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);


            //Create Variables to hold and store values 
            // Console.WriteLine("What is Your First Name?"); // Asks user in terminal
            // String name1 = Console.ReadLine(); // takes in users input for variable name1
            //
            // Console.WriteLine("How old are you?"); // Asks user in terminal
            // int age1 = Convert.ToInt32(Console.ReadLine()); 
            //
            // Console.WriteLine("Hello my name is " + name1 + " ,and I am " + age1 + " years old."); // Returns Hello {users input}
            
            
            
            // Basic Arithmetic Lesson <--------------------------------------------------------------------------------

            int friends = 5;
            friends = friends + 1; // returns 6
            // friends = friends + 2;// returns 8
            
            // += shortcut (same as above but shorter version)
            friends += 2; // returns 8
            Console.WriteLine(friends);
            
            
            
            // Increment/Decrement examples

            int friends2 = 5;
            
            //these all do the same thing
            // friends2 = friends2 + 1;
            // friends2 += 1;
            friends2 ++;
            Console.WriteLine(friends2);
            
            //Multiplication Example
            int friends3 = 5;
            // friends3 = friends3 * 2; // returns 10
            friends3 *= 2; // return s 10
            Console.WriteLine(friends3);
            
            //Division Example
            int friends4 = 6;
            // friends4 = friends4 / 2;
            friends4 /= 2;
            Console.WriteLine(friends4);
            
            // Module Operator (%) // lets you know if your number is whole or decimal number
            int remainder = 25 % 2;
            Console.WriteLine(remainder);
            
            // Math Class Examples <-------------------------------------------------------------------------------

            double t = 3.5;
            double p = 5;

            double pow = Math.Pow(t, 2); // Math.Pow (Exponents) -  (first value is base number, second is exponent)
            Console.WriteLine(pow); // returns 12.25

            double sqrt = Math.Sqrt(t); // Math.Sqrt - Returns sqrt of number
            Console.WriteLine(sqrt); // returns 1.870828

            double abs = Math.Abs(t); // Math.Abs (Absolute Value) - returns positive version of number
            Console.WriteLine(abs); // returns 3

            double round = Math.Round(t); // Math.Round -  Rounds Number( Up or Down Based on decimal)
            Console.WriteLine(round); // returns 4

            double ceil = Math.Ceiling(t); // Math.Ceiling - Rounds Number Up No matter What the decimal is
            Console.WriteLine(ceil); // returns 4

            double floor = Math.Floor(t); // Math.Floor - Rounds number Down no matter what  the decimal is 
            Console.WriteLine(floor); // returns 3

            double max = Math.Max(t, p); // Math.Max - Returns highest number in list of numbers
            Console.WriteLine(max);// returns 5
            
            double min = Math.Min(t, p); // Math.Min - returns lowest number in list of numbers
            Console.WriteLine(min);//  returns 3.5


            // Generate Random NUMBERS <-------------------------------------------------------------------------------
            
            
            
        }
    }  
        }
        
    



