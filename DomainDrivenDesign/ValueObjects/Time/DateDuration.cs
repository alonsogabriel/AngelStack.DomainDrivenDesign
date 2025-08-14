namespace DomainDrivenDesign.ValueObjects.Time;

public enum DateDurationUnit
{
    Days,
    Weeks,
    Months,
    Years,
}

public record DateDuration
{
    public DateDuration(int value, DateDurationUnit unit)
    {
        if (value < 0)
        {
            throw new ArgumentException("Value can not be negative.", nameof(value));
        }

        Value = value;
        Unit = unit;
    }

    public int Value { get; protected set; }
    public DateDurationUnit Unit { get; protected set; }
}