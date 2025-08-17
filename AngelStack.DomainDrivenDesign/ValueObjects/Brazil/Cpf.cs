using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.Validators;

namespace AngelStack.DomainDrivenDesign.ValueObjects.Brazil;

public record Cpf : StringValue
{
    public Cpf(string value) : base(value)
    {
        Value = value;
    }

    protected override void Validate()
    {
        if (!CpfValidator.Validate(Value))
        {
            throw new Exception("Invalid cpf.");
        }
    }
}
