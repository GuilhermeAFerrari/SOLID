using System.Drawing;

namespace ISP.Vehicles;

class Motorcycle : IVehicleMotorcycle
{
    private string Color;
    private int Year;
    private double Engine;

    public Motorcycle(string color, int year, double engine)
    {
        ConfigureMotorcycle(color, year, engine);
    }

    public void ConfigureMotorcycle(string color, int year, double engine)
    {
        Color = color;
        Year = year;
        Engine = engine;

        Console.WriteLine($"Criando uma moto cor: {Color}, ano: {Year}, cilindradas: {Engine}.");
        StartVehicle();
    }

    public void StartVehicle()
    {
        Console.WriteLine("Ligando os motores...");
    }
}
