using System.Security.Cryptography.X509Certificates;

namespace OCP.Vehicles;

public class Car : Vehicle
{
    private int Doors;
    private int Seats;

    public Car(string color, int year, double engine, int doors, int seats) : base(color, year, engine)
    {
        Doors = doors;
        Seats = seats;
        ConfigureCar();
    }

    public void ConfigureCar()
    {
        Console.WriteLine($"Criando um carro {Color}, {Year}, {Engine}, {Doors} portas e {Seats} assentos.");
        StartVehicle();
    }
}
