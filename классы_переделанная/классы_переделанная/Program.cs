public abstract class figura
{
    public abstract double Ploshad();
}
class Paralelogram:figura
{
    private int dlinnafiguru;
    private int shirinafiuru;

    public Paralelogram(int dlinnafiguru, int shirinafiuru)
    {
        this.dlinnafiguru = dlinnafiguru;
        this.shirinafiuru = shirinafiuru;
    }
    public override double Ploshad()
    {
        return dlinnafiguru * shirinafiuru;
    }
}
class Krug : figura
{
    private double radius;
    public Krug(double radius)
    {
        this.radius = radius;
    }
    public override double Ploshad()
    {
        return radius * Math.PI;
    }
}
class Cilindr : figura
{
    private double radius_cilindra;
    private double vusota_cilindsa;
    public Cilindr(double radius_cilindra, double vusota_cilindsa)
    {
        this.radius_cilindra = radius_cilindra;
        this.vusota_cilindsa = vusota_cilindsa;
    }
    public override double Ploshad()
    {
        return radius_cilindra * vusota_cilindsa * Math.PI;
    }
}
class Program
{
    static void Main()
    {
        int shirinafiuru = int.Parse(Console.ReadLine());
        int dlinnafiguru = int.Parse(Console.ReadLine());
        Paralelogram figura_1 = new Paralelogram(dlinnafiguru, shirinafiuru);
        Console.WriteLine(figura_1.Ploshad());

        double radius = double.Parse(Console.ReadLine());
        Krug figura_2 = new Krug(radius);
        Console.WriteLine(figura_2.Ploshad());

        double radius_cilindra = double.Parse(Console.ReadLine());
        double vusota_cilindra = double.Parse(Console.ReadLine());
        Cilindr figura_3 = new Cilindr(radius_cilindra, vusota_cilindra);
        Console.WriteLine(figura_3.Ploshad());
    }
}
