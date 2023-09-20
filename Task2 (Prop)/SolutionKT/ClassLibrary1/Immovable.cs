namespace ClassLibrary1
{
    public class Immovable : Property
    {
        public int Area;
        public Immovable(int worth, int area) : base(worth)
        {
            Area = area;
        }

        public override double CalcProp()
        {
            double TaxWorth = 0;
            if (Area < 100)
            {
                TaxWorth = Worth / 500;
            }
            else
            {
                if ((Area > 100) & (Area < 100))
                {
                    TaxWorth = Worth / 350;
                }
                else
                {
                    if (Area > 300)
                    {
                        TaxWorth = Worth / 250;
                    }
                }
            }
            return TaxWorth;
        }
        
        public double CubeWorth()
        {
            double cmw;
            cmw = Area / Worth;
            return cmw;
        }
    }
}