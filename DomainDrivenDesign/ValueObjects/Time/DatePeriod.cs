using DomainDrivenDesign.Abstractions.Extensions;

namespace DomainDrivenDesign.ValueObjects.Time;

public record DatePeriod
{
    public DatePeriod(DateOnly startDate, DateDuration duration)
    {
        StartDate = startDate;
        Duration = duration.Guard(new ArgumentNullException(nameof(duration)));
    }

    public DateOnly StartDate { get; set; }
    public DateDuration Duration { get; set; }

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
