class Paralelogram
{
    private int dlinnafiguru;
    private int shirinafiuru;

    public Paralelogram(int dlinnafiguru, int shirinafiuru)
    {
        this.dlinnafiguru = dlinnafiguru;
        this.shirinafiuru = shirinafiuru;
    }
    public int Ploshad (int dlinna, int shirina)
    {
        return dlinna * shirina;
    }
}
class Krug
{
    private double radius;
    public Krug(double radius)
    {
        this.radius = radius;
    }
    public double Ploshad(double radius)
    {
        return radius * Math.PI;
    }
}
class Cilindr
{
    private double radius_cilindra;
    private double vusota_cilindsa;
    public Cilindr(double radius_cilindra, double vusota_cilindsa)
    {
        this.radius_cilindra = radius_cilindra;
        this.vusota_cilindsa = vusota_cilindsa;
    }
    public double Ploshad(double radius_cilindra, double vusota_cilindsa)
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
            Console.WriteLine(figura_1.Ploshad(dlinnafiguru, shirinafiuru));
            
            double radius = double.Parse(Console.ReadLine());
            Krug figura_2 = new Krug(radius);
            Console.WriteLine(figura_2.Ploshad(radius));

            double radius_cilindra=double.Parse(Console.ReadLine());
            double vusota_cilindra= double.Parse(Console.ReadLine());
            Cilindr figura_3=new Cilindr(radius_cilindra, vusota_cilindra);
            Console.WriteLine(figura_3.Ploshad(radius_cilindra,vusota_cilindra));
        }
    }
