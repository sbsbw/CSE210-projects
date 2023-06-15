using System;

public class Circle : Shape
{
    private float _radius;

    public Circle(string color, float radius)
    {
        _color = color;
        _radius = radius;
    }

    // Overide the method from the base class.
    public override float GetArea()
    {
        float pi = (float) Math.PI;
        float area = pi * (_radius * _radius);
        return area;
    }
}