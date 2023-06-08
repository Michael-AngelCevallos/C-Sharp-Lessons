namespace C_Sharp_Lessons;

public class CAR
{
    public String model;
    public int year;
    public String color;
    
    // 3. USED FOR STATIC LESSON - STEP 2 WILL ONLY WORK IF YOU MAKE THIS VARIABLE STATIC
    public static int numberOfCars;
    

    public CAR(String color, int year, String model)
    {
        this.color = color;
        this.model = model;
        this.year = year;
        
        // 2. USED IN STATIC LESSON - THIS WILL ADD ANOTHER INSTIATION OF CAR OBJECT WHEN ONE IS CREATED;
        numberOfCars++;
    }

    public void Car()
    {
        Console.WriteLine("The Color of the car is " + color + ". The year of the car is " + year + ". The model of the car is " + model + ".");
        
    }
    
    // public void Color()
    // {
    //     color = "Blue";
    //     Console.WriteLine("The Color of the car is " + color);
    // }
    //
    // public void Model()
    // {
    //     model = "Chevy";
    //     Console.WriteLine("The Model is a " + model);
    // }
    //
    // public void Year()
    // {
    //     year = 2017;
    //     Console.WriteLine("The Year of the car is " + year);
    // }
    //

   
}