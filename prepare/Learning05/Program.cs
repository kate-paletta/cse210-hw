using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("Blue", 4);
        

        Rectangle rectangle = new("Yellow", 3, 2);

        Circle circle = new("Green", 2);
        

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