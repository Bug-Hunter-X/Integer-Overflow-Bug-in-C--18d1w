public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void IncrementValue()
    {
        // Solution: Check for integer overflow before incrementing
        if (_value == int.MaxValue)
        {
            throw new OverflowException("Integer overflow detected");
        }
        _value++;
    }
}