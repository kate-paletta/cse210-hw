public class Square : Shape
{
    private int _side;

    public override double GetArea()
    {
        return _side * _side;
    }
}