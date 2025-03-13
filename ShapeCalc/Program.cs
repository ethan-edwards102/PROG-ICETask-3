using ShapeCalc;

Console.WriteLine("Enter circle radius");
double radius = double.Parse(Console.ReadLine());

Circle c = new Circle("steve", radius);

c.Display();
Console.WriteLine("Circle area: " + c.CalculateArea());

Console.WriteLine("Enter rectangle width and height");
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

Rectangle r = new Rectangle("bob", width, height);

r.Display();
Console.WriteLine("Rectangle area: " + r.CalculateArea());