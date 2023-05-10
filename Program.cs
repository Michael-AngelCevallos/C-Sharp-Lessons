﻿using System;

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
            
            
            // How To Format Output
            Console.Write("Hey"); // Console.Write will not hit enter key after declaration
            Console.WriteLine("Hey is on the same line as this one"); // Console.Writeline Will Hit Enter key after Declaration
            
            // Auto generate Console.Writeline ( c + w + tab)
            Console.WriteLine();
            
            // Console Escape Sequences 
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

            // Display Message with String

            int age = 29; // Integer(int) -Whole Number
            Console.WriteLine("My age is " + age);

            double height = 68.5; // Double(decimal number) - Decimal Number
            Console.WriteLine("My height is " + height + "in");

            bool on = true; // Boolean(bool)- True/False
            Console.WriteLine("Is that Light On? " + on);

 




        }
    }  
        }
        
    



