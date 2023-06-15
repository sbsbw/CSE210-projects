using System;

public class Square : Shape
{
    private float _side;

    public Square(string color, float side)
    {
        _color = color;
        _side = side;
    }

    // Overide the method from the base class.
    public override float GetArea()
    {
        float area = _side * _side;
        return area;
    }
}