namespace ClassLibrary1
{
    public class Vehicle : Property
    {
        public int HorsePower;
        public Vehicle(int worth, int horsep) : base(worth)
        {
            HorsePower = horsep;
        }
        
        public override double CalcProp()
        {
            double TaxWorth;
            TaxWorth = Worth * HorsePower / 3000;
            return TaxWorth;
        }
    }
}