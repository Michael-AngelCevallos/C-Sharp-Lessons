namespace C_Sharp_Lessons;

public class CAR
{
    public String model;
    public int year;
    public String color;


    public void Color()
    {
        color = "Blue";
        Console.WriteLine("The Color of the car is " + color);
    }

    public void Model()
    {
        model = "Chevy";
        Console.WriteLine("The Model is a " + model);
    }
    
}