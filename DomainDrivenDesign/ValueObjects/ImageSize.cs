namespace DomainDrivenDesign.ValueObjects;

public record ImageSize
{
    public ImageSize(long value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Value can not be negative.", nameof(value));
        }

        Value = value;
    }
    public long Value { get; protected set; }
}