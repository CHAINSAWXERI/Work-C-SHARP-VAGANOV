namespace ClassLibrary1;

public class CuteCat : Cat
{
    public override int Fluffiness { get; }
    
    public CuteCat(int _fluffiness)
    {
        
        if (0 <= _fluffiness & _fluffiness <= 140.0)
        {
            Fluffiness = _fluffiness;
        }
        else
        {
            throw new CatExeption("Unable to create a tiger with Fluffiness: " + _fluffiness);
        }
    }

    public override string FluffinessCheck()
    {
        int c = 0;
        if (Fluffiness == 0)
        {
            return "Sphynx";
        }
        else
        {
            if (1 <= Fluffiness & Fluffiness <= 20)
            {
                return "Slightly";
            }
            else
            {
                if (21 <= Fluffiness & Fluffiness <= 50)
                {
                    return "Medium";
                }
                else
                {
                    if (51 <= Fluffiness & Fluffiness <= 75)
                    {
                        return "Heavy";
                    }
                    else
                    {
                        return "OwO";
                    }
                }
            }
        }
    }
    
    public override string ToString()
    {
        return "A cute cat with fluffiness: " + Fluffiness;
    }
}