namespace C_Sharp_Lessons;

// Used for Objects Lesson <--------

// 1. create a Human class that will state fields and methods for human objects
public class Human
{
   // 2.  Make some fields - or attributes that a human would have, such as name, hair color, etc.
   // 3. Start by Making variables of these charteristics
   public String name ;
   public int age;
   
   // 4. make some methods for the human, this will declare the actions a human can do
   public void Eat()
   {
      // 5. give this method an action when called upon in the main method
      Console.WriteLine(name + " is eating");
   }

   public void Sleep()
   {
      Console.WriteLine(name + " is sleeping");
   }

   public void Age()
   {
      Console.WriteLine(name + " is " + age + " years old");
   }


}