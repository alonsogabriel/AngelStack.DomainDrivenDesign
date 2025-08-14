namespace DomainDrivenDesign.ValueObjects.Time;

public class TimeRange
{
    public TimeRange(TimeOnly startTime, TimeOnly endTime)
    {
        if (startTime > endTime)
        {
            throw new ArgumentException("Start time can not be later than end time.", nameof(startTime));
        }

        StartTime = startTime;
        EndTime = endTime;
    }
    public TimeOnly StartTime { get; protected set; }
    public TimeOnly EndTime { get; protected set; }
}
