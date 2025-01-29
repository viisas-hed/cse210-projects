public class Fraction
{
    private int _numerator ;
    private int _denominator ;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int WholeNumber)
    {
        _numerator = WholeNumber ;
        _denominator = 1;
    }
    public Fraction(int Numerator, int Denominator)
    {
        _numerator = Numerator;
        _denominator = Denominator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int Numerator)
    {
        _numerator = Numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int Denominator)
    {
        _denominator = Denominator;
    }

    public string GetFractionString()
    {
        return ($"{_numerator}/{_denominator}");
    }

    public double GetDecimalValue()
    {
        double doubleNumerator = _numerator;
        double doubleDenominator = _denominator;
        return (doubleNumerator/doubleDenominator);
    }
}