using System;

public class Fraction
{
    // Define attributes.
    private int _top;
    private int _bottom;

    // Create contructors for the Fraction class.
    public Fraction()
    {
        // Set both parameters to 1.
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {   
        // Set the top of the fraction to given number and the bottom to 1.
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {   
        // Set the top and bottom of the fraction to given numbers.
        _top = top;
        _bottom = bottom;
    }

    // Create methoods to Get/Set fraction data.
    public void SetTop(int top)
    {
        // Set top to the value given.
        _top = top;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetBottom(int bottom)
    {
        // Set bottom to the value given.
        _bottom = bottom;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        string fractionString = _top.ToString() + "/" + _bottom.ToString();
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }
}