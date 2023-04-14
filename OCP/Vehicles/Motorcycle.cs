namespace OCP.Vehicles;

public class Motorcycle : Vehicle
{
    public Motorcycle(string color, int year, double engine) : base(color, year, engine)
    {
        ConfigureMotorcycle();
    }

    public void ConfigureMotorcycle()
    {
        Console.WriteLine($"Criando uma moto {Color}, {Year}, {Engine} cilindradas.");
        StartVehicle();
    }
}
