internal class Circle : Shape
{
    private double Radius { get; set; }
    public Circle(string Color, double radius) : base(Color, "Circle")
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}