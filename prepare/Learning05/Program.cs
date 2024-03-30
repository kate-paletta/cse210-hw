using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new();
        square.SetColor("Blue");
        square.SetSide(2);

        Rectangle rectangle = new();
        rectangle.SetColor("Pink");
        rectangle.SetLength(3);
        rectangle.SetWidth(2);

        Circle circle = new();
        circle.SetColor("Green");
        circle.SetRadius(4);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shp in shapes)
        {
            double _area = shp.GetArea();
            string _color = shp.GetColor();
            Console.WriteLine($"Color: {_color} Area: {_area}");
        }

    }
}