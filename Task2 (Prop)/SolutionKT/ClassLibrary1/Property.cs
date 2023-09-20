namespace ClassLibrary1
{
    public abstract class Property
    {
        public int Worth;

        public Property(int worth)
        {
            Worth = worth;
        }

        public abstract double CalcProp();
    }
}