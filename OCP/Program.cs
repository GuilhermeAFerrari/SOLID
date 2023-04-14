using OCP.Enums;
using OCP.Vehicles;

TypeVehicle typeVehicle = TypeVehicle.Car;

if (typeVehicle == TypeVehicle.Car)
{
    Vehicle vehicle = new Car("Preto", 2014, 1.6, 4, 5);
}
else if (typeVehicle == TypeVehicle.Motorcycle)
{
    Vehicle vehicle = new Motorcycle("Verde limão", 2020, 350);
}
else
{
    throw new NotImplementedException();
}