namespace OCP.Vehicles;

public class Vehicle : IVehicle
{
    protected string Color;
    protected int Year;
    protected double Engine;

    public Vehicle(string color, int year, double engine)
    {
        Color = color;
        Year = year;
        Engine = engine;
    }

    public void StartVehicle()
    {
        Console.WriteLine("Ligando os motores");
    }
}
