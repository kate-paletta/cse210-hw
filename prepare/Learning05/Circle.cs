public class Circle : Shape
{
    private double _radius;
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        radius = _radius;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius*_radius);
    }
}