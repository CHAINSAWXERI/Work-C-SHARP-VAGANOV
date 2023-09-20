using System;

namespace ClassLibrary1
{
    public class Appartment : Immovable
    {
        public Appartment(int worth, int area) : base(worth, area)
        {
            
        }
        
        public override string ToString()
        {
            double taxWorth = CalcProp();
            return "Машина: Стоимость - " + Worth + ", Налог - " + taxWorth + ", площадь  - " + Area + " кв.м";
        }
    }
}