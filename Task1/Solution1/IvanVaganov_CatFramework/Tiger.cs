namespace ClassLibrary1;

public class Tiger : Cat
{
    private double weight;
    public override int Fluffiness { get; }
    
    public Tiger(double _weight, int _fluffiness)
    {
        if (75.0 <= _weight & _weight <= 140.0)
        {
            weight = _weight;
        }
        else
        {
            throw new CatExeption("Unable to create a tiger with weight: " + _weight);
        }
        
        if (0 <= _fluffiness & _fluffiness <= 100)
        {
            Fluffiness = _fluffiness;
        }
        else
        {
            throw new CatExeption ("Unable to create a tiger with Fluffiness: " + _fluffiness);
        }
    }
    
    public override string FluffinessCheck()
    {
        return "Kycb!";
    }
    
    public override string ToString()
    {
        return "A cat with fluffiness: " + Fluffiness + " A cat with weight: " + weight;
    }
}