namespace AngelStack.DomainDrivenDesign.ValueObjects.Time;

public record DateRange
{
    public DateRange(DateOnly startDate, DateOnly endDate)
    {
        if (startDate > endDate)
        {
            throw new ArgumentException("Start date can not be later than end date.", nameof(startDate));
        }

        StartTime = startDate;
        EndTime = endDate;
    }
    public DateOnly StartTime { get; protected set; }
    public DateOnly EndTime { get; protected set; }
}