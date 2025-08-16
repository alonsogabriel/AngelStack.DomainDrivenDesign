using AngelStack.Common.Guards;

namespace AngelStack.DomainDrivenDesign.ValueObjects.Time;

public record TimePeriod
{
    public TimePeriod(TimeOnly startTime, TimeDuration duration)
    {
        StartTime = startTime;
        Duration = duration.Guard();
    }
    public TimeOnly StartTime { get; protected set; }
    public TimeDuration Duration { get; protected set; }

    public TimeOnly EndTime => TimeOnly.FromDateTime(GetEndTime());

    public DateTime GetEndTime()
    {
        var startTime = DateTime.Today.Add(StartTime.ToTimeSpan());

        return Duration.Unit switch
        {
            TimeDurationUnit.Seconds => startTime.AddSeconds(Duration.Value),
            TimeDurationUnit.Minutes => startTime.AddMinutes(Duration.Value),
            TimeDurationUnit.Hours => startTime.AddHours(Duration.Value),
            _ => throw new ArgumentException("Invalid time duration unit.", nameof(Duration.Unit)),
        };
    }
}