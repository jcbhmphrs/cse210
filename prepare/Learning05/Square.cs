internal class Square : Shape
{
    private double SideLength { get; set; }

    public Square(string Color, double sideLength) : base(Color, "Square")
    {
        SideLength = sideLength;
    }

    public override double GetArea()
    {
        return Math.Pow(SideLength, 2);
    }
}