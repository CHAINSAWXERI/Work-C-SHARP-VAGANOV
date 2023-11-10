using AbstractClasses_Task3;
using System.Drawing;
using System.Xml.Linq;

namespace AbstractClasses_Task3
{
    public abstract class Product
    {
        public string Name;
        public int LQ; //Level Quality;
        public int BBD; // best before date

        public Product(string name, int lq, int bbd)
        {
            Name = name;
            LQ = lq;
            BBD = bbd;
        }

        public abstract string GetInfo();
    }

    public class Electronics : Product
    {
        public string Version;

        public Electronics(string name, int lq, int bbd, string version) : base(name, lq, bbd)
        {
            Version = version;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, Level Quality: {LQ}, Best Before Date: {BBD}, Version: {Version}";
        }
    }

    public class Clothing : Product
    {
        public int Size;

        public Clothing(string name, int lq, int bbd, int size) : base(name, lq, bbd)
        {
            Size = size;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, Level Quality: {LQ}, Best Before Date: {BBD}, Size: {Size}";
        }
    }

    public class Food : Product
    {
        public string Type;

        public Clothing(string name, int lq, int bbd, string type) : base(name, lq, bbd)
        {
            Type = type;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, Level Quality: {LQ}, Best Before Date: {BBD}, Typr: {Type}";
        }
    }

    class Program
    {
        static void Main()
        {
            Electronics electronicProduct1 = new Electronics("Smartphone", 5, 2023, "v2.0");
            Clothing clothingProduct1 = new Clothing("T-shirt", 4, 2025, 10);
            Food foodProduct1 = new Food("Bread", 3, 2022, "Whole wheat");

            List<Product> productsCollection = new List<Product> { electronicProduct1, clothingProduct1, foodProduct1 };

            for (int i = 0; i < productsCollection.Count; i++)
            {
                Product product = productsCollection[i];
                Console.WriteLine(product.GetInfo());
            }
        }
    }
}

