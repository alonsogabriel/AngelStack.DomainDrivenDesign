using AngelStack.DomainDrivenDesign.Abstractions;

namespace DomainDrivenDesign.ValueObjects;

// [StringValidation(MinLength = MIN_LENGTH, MaxLength = MAX_LENGTH, Pattern = "^[A-Za-z0-9\\-\\.]+$")]
public record ZipCode : StringValueValidatable
{
    public const int MIN_LENGTH = 1;
    public const int MAX_LENGTH = 40;
    public ZipCode(string value) : base(value) { }
}