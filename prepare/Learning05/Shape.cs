internal abstract class Shape
{
    public string Color { get; set; }
    public string Type { get; set; }
    public Shape(string color, string type)
    {
        Color = color;
        Type = type;
    }

    public abstract double GetArea();
}