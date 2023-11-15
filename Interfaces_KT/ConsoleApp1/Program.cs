using Interfaces_KT;

Car car = new Car(15);
Console.WriteLine("Введите количество бензина для заправки:");
int fuelToAdd = Convert.ToInt32(Console.ReadLine());
car.Refuel(fuelToAdd);
car.Drive();
