using System;

namespace ClassLibrary1
{
    public class Boat : Vehicle
    {
        public Boat(int worth, int horsep) : base(worth, horsep)
        {
            
        }
        
        public override string ToString()
        {
            double taxWorth = CalcProp();
            return "Машина: Стоимость - " + Worth + ", Налог - " + taxWorth + ", объём двигателя - " + HorsePower + " см.куб";
        }
    }
}