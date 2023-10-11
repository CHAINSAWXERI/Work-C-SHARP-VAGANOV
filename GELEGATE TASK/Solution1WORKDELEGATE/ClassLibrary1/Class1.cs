namespace ClassLibrary1;

public class Calculation 
{
    public double Factorial(double a)
    {
        if (a % 1 == 0)
        {
            if (a == 0) return 1;

            if (a > 0)
            {
                int _ = 1;

                for (int i = 1; i <= a; i++)
                {
                    _ *= i;
                }
                return _;
            }
        }
        return double.NaN;
    }
    
    public int NumSum(int a)
    {
        if (a >= 10)
        {
            int s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a /10 ;
            }
            return a;
        }
        else
        {
            return a;
        }
    }
    
    public int NumMult(int a)
    {
        if (a >= 10)
        {
            int s = 0;
            while (a > 0)
            {
                s = s * a % 10;
                a = a /10 ;
            }
            return a;
        }
        else
        {
            return a;
        }
    }
    
    public void PrintSum(double a)
    {
        Console.WriteLine(NumSum((int)a));
    }
    
    public void PrintMult(double a)
    {
        Console.WriteLine(NumSum((int)a));
    }
    
    public int RemoveOdd(int a)
    {
        
    }
}