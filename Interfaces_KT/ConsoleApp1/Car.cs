namespace Interfaces_KT;

class Car : IVehiculo
{
    private int fuel;

    public Car(int initialFuel)
    {
        fuel = initialFuel;
    }

    public void Drive()
    {
        if (fuel > 0)
        {
            Console.WriteLine("Автомобиль находится в движении");
        }
        else
        {
            Console.WriteLine("Нет бензина, автомобиль не может двигаться");
        }
    }

    public bool Refuel(int amount)
    {
        fuel += amount;
        Console.WriteLine("Автомобиль заправлен на " + amount + " литров");
        return true;
    }
}