namespace DomainDrivenDesign.ValueObjects.Time;

public enum TimeDurationUnit
{
    Seconds,
    Minutes,
    Hours,
}
public record TimeDuration
{
    public TimeDuration(int value, TimeDurationUnit unit)
    {
        if (value < 0)
        {
            throw new ArgumentException("Value can not be negative.", nameof(value));
        }

        Value = value;
        Unit = unit;
    }
    public int Value { get; protected set; }
    public TimeDurationUnit Unit { get; protected set; }
}