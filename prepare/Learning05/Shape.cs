using System.Drawing;

public abstract class Shape
{
    protected string _color;

    public string GetColor()
    { 
        return _color;
    }
    public void SetColor(string color)
    {
        color = _color;
    }

    public abstract double GetArea();
}