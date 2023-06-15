using System;

public class Shape
{
    // Define the attributes.
    protected string _color;

    // Write methods for your shapes.
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual float GetArea()
    {
        return 0;
    }
}