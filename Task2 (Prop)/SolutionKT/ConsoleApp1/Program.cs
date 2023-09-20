using ClassLibrary1;

static void Main(string[] args)
{
    Appartment Siem = new Appartment(5000000, 40);
    Appartment Home = new Appartment(10000000, 70);
    Appartment Studio = new Appartment(1000000, 20);
    Car ieight = new Car(9000000, 120);
    Car Mers = new Car(20000000, 90);
    Car gatti = new Car(100000000, 160);
    Boat lilboat = new Boat(10000000, 120);
    Boat bigboat = new Boat(100000000, 240);
    CountryHouse secondhoume = new CountryHouse(500000000, 1000);
    CountryHouse forparty = new CountryHouse(40000000, 300);
    Property[] mythings = new Property[10] {Siem, Home, Studio, ieight, Mers, gatti, lilboat, bigboat, secondhoume, forparty};
    for (int i = 0; i < mythings.Length; i++)
    {
        mythings[i].ToString();
    }
}