namespace ShapeCalc;

public class Circle : Shape, ICalculateArea
{
    public double Radius { get; set; }
    
    public Circle(string name, double radius) : base(name)
    {
        this.Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}