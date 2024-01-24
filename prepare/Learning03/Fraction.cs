// Fraction.cs

public class Fraction

{
    private int _top;
    private int _bottom;

    //Constructor for1/1 fraction
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor with 1 parameter for the top
    //public Fraction(int topValue)
    //{
        //_top = topValue;
        //_bottom = 1;
    //}
    // this worked, but the sample solution says:
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //Constricter with 2 parameters for top & bottom
    //public Fraction(int topValue, int bottomValue)
    //{
        //_top = topValue;
        //_bottom = bottomValue;
    //} 
    //this worked too, but sample solution says:
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    //setters & getters
    // public int GetTop()
    // {
    //     return _top;
    // }

    // public void SetTop(int topValue)
    // {
    //     _top = topValue;
    // }

    // public int GetBottom()
    // {
    //     return _bottom;
    // }

    // public void SetBottom(int bottomValue)
    // {
    //     _bottom = bottomValue;
    // }
    // re-read the instrucitons, which talk about staying away from these

    // methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}