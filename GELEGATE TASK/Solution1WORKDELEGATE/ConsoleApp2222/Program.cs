delegate double DelTsk31(int a, double b);
delegate int DelTsk32(int a, double b);
delegate int DelTsk33(int a, double b);
delegate void DelTsk34(int a, double b);
delegate void DelTsk35(int a, double b);

delegate int DelTsk4(int a, double b);

delegate int DelTsk5(int a, double b);

delegate void DelTsk6(int a, double b);
delegate void DelTsk61(int a, double b);
delegate void DelTsk62(int a, double b);

delegate double DelTsk71(int a, double b);

delegate int DelTsk72(int a, double b);

class Calculation
{
    static void Main(String[] args)
    {
        //2
        
        //3
        DelTsk31 del31 = Factorial;
        DelTsk32 del32 = NumSum;
        DelTsk33 del33 = NumMult;
        DelTsk34 del34 = PrintSum;
        DelTsk35 del35 = PrintMult;

        del31.Invoke(0, 2);
        del32.Invoke(2, 0);
        del33.Invoke(2, 0);
        del34.Invoke(2, 0);
        del35.Invoke(2, 0);

        
        //4
        DelTsk4 del4;
        del4 = NumSum;
        del4 += NumMult;
        del4.Invoke(55, 12);
        
        //5
        for (int i = 0; i < 1;)
        {
            DelTsk5 del5 = NumSum;
            string x = Console.ReadLine();
            del5 -= NumSum;
            if (x == "Добавить NumSum")
            {
                del5 += NumSum;
            }

            if (x == "Добавить NumMult")
            {
                del5 += NumMult;
            }
            
            if (x == "Убрать NumSum")
            {
                del5 -= NumSum;
            }

            if (x == "Убрать NumMult")
            {
                del5 -= NumMult;
            }
            
            if (x == "Активировать")
            {
                del5.Invoke(55, 12);
            }
        }
        
        //6
        DelTsk6 del6 = MethodTsk6;
        del6.Invoke(15, 0);
        del6.Invoke(14, 0);
        
        //7
        DelTsk71 del71 = Factorial;
        DelTsk72 del72 = NumMult;
        del72 += NumSum;
        double p = del71.Invoke(0, 13);
        Console.WriteLine(del72.Invoke((int)p, 0));

    }
    
    public static double Factorial(int a, double b)
    {
        if (b % 1 == 0)
        {
            if (b == 0) return 1;

            if (b > 0)
            {
                int _ = 1;

                for (int i = 1; i <= b; i++)
                {
                    _ *= i;
                }
                return _;
            }
        }
        return double.NaN;
    }
    
    public static int NumSum(int a, double b)
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
    
    public static int NumMult(int a, double b)
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
    
    public static void PrintSum(int a, double b)
    {
        Console.WriteLine(NumSum(a,b));
    }
    
    public static void PrintMult(int a, double b)
    {
        Console.WriteLine(NumSum(a,b));
    }
    
    public static void MethodTsk6(int a, double b)
    {
        DelTsk61 del61 = PrintSum;
        DelTsk62 del62 = PrintMult;
        if (a % 2 == 0)
        {
            del61.Invoke(a, b);
        }
        else
        {
            del62.Invoke(a, b);
        }
    }
}
