using ClassLibrary1;

static void Main(string[] args)
{
    Cat[] CatsMass = GenerateRandomCats(6);
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(CatsMass[i]);
    }
}

static Cat[] GenerateRandomCats(int catCount)
{
    Cat[] CatsMass = new Cat[catCount];

    for (int i = 0; i < catCount; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(0, 1);
        if (value == 0)
        {
            Random rndW = new Random();
            double weight = rndW.Next(50, 160);
            Random rndF = new Random();
            int Fluffiness = rndF.Next(-20, 120);
            Tiger RndCat = new Tiger(weight, Fluffiness);
            CatsMass[i] = RndCat;
        }
        else
        {
            Random rndF = new Random();
            int Fluffiness = rndF.Next(-20, 120);
            CuteCat RndCat = new CuteCat(Fluffiness);
            CatsMass[i] = RndCat;
        }
        
    }

    return CatsMass;
}