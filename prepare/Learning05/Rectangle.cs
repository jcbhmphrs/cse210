internal class Rectangle : Shape
{
    private double Height { get; set; }
    private double Width { get; set; }

    public Rectangle(string Color, double height, double width) : base(Color, "Rectangle")
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}