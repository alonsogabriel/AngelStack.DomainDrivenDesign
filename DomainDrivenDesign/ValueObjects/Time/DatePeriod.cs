using AngelStack.Common.Guards;

namespace AngelStack.DomainDrivenDesign.ValueObjects.Time;

public record DatePeriod
{
    public DatePeriod(DateOnly startDate, DateDuration duration)
    {
        StartDate = startDate;
        Duration = duration.Guard();
    }

    public DateOnly StartDate { get; protected set; }
    public DateDuration Duration { get; protected set; }

    public DateOnly GetEndDate()
    {
        return Duration.Unit switch
        {
            DateDurationUnit.Days => StartDate.AddDays(Duration.Value),
            DateDurationUnit.Weeks => StartDate.AddDays(7 * Duration.Value),
            DateDurationUnit.Months => StartDate.AddMonths(Duration.Value),
            DateDurationUnit.Years => StartDate.AddYears(Duration.Value),
            _ => throw new ArgumentException("Invalid unit.", nameof(Duration.Unit)),
        };
    }
}
