namespace AngelStack.DomainDrivenDesign.ValueObjects.Time;

public record DateTimeRange
{
    public DateTimeRange(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
        {
            throw new ArgumentException("Start datetime can not be later than end datetime.", nameof(startDate));
        }

        StartDate = startDate;
        EndDate = endDate;
    }
    public DateTime StartDate { get; protected set; }
    public DateTime EndDate { get; protected set; }
}
