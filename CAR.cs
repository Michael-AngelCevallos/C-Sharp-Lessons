namespace C_Sharp_Lessons;

public class CAR
{
    public String model;
    public int year;
    public String color;
    private int numberOfCars;
    

    public CAR(String color, int year, String model)
    {
        this.color = color;
        this.model = model;
        this.year = year;
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