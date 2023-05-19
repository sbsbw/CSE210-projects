using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        string fraction1String = fraction1.GetFractionString();
        string fraction2String = fraction2.GetFractionString();
        string fraction3String = fraction3.GetFractionString();
        string fraction4String = fraction4.GetFractionString();


        double fraction1Decimal = fraction1.GetDecimalValue();
        double fraction2Decimal = fraction2.GetDecimalValue();
        double fraction3Decimal = fraction3.GetDecimalValue();
        double fraction4Decimal = fraction4.GetDecimalValue();

        Console.WriteLine(fraction1String);
        Console.WriteLine(fraction1Decimal);
        Console.WriteLine(fraction2String);
        Console.WriteLine(fraction2Decimal);
        Console.WriteLine(fraction3String);
        Console.WriteLine(fraction3Decimal);
        Console.WriteLine(fraction4String);
        Console.WriteLine(fraction4Decimal);
    }
}