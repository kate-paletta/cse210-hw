public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        length = _length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        width = _width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}