using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.DomainObjects.ValueObjects;
using DomainDrivenDesign.DomainObjects.ValueObjects.Brazil;

namespace DomainDrivenDesign.DomainObjects.Entities;

public abstract class AbstractBrazilPerson : AbstractPerson
{
    protected AbstractBrazilPerson()
    {
    }

    public AbstractBrazilPerson(Cpf cpf, PersonName name, DateOfBirth? dateOfBirth, Gender? gender)
        : base(name, dateOfBirth, gender)
    {
        Cpf = cpf.Guard(new ArgumentNullException(nameof(cpf)));
    }

    public Cpf? Cpf { get; set; }
}
