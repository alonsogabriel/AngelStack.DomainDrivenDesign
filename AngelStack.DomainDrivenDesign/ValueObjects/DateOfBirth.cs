namespace AngelStack.DomainDrivenDesign.ValueObjects;

public record DateOfBirth(DateOnly Value)
{
    public int GetAge()
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);
        var age = today.Year - Value.Year;

        if (today < Value.AddYears(age))
        {
            age--;
        }

        return age;
    }
}