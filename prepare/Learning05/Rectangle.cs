using System;

public class Rectangle : Shape
{
    private float _side1;
    private float _side2;

    public Rectangle(string color, float side1, float side2)
    {
        _color = color;
        _side1 = side1;
        _side2 = side2;
    }

    // Overide the method from the base class.
    public override float GetArea()
    {
        float area = _side1 * _side2;
        return area;
    }
}