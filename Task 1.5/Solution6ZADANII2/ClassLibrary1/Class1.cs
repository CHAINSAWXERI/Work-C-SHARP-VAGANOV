namespace ClassLibrary1;

public class Kucha<T>
{
    public T Valve { get; set; }

    public Kucha(T valve)
    {
        this.Valve = valve;
    }

    public void Reset()
    {
        Valve = default(T);
    }
}