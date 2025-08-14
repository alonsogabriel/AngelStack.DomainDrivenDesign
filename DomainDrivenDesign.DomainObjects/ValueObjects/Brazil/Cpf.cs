using DomainDrivenDesign.Abstractions.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.ValueObjects.Brazil;

public record Cpf : StringValue
{
    public Cpf(string value) : base(value)
    {
    }

    protected override void Validate()
    {
        throw new NotImplementedException();
    }
}
