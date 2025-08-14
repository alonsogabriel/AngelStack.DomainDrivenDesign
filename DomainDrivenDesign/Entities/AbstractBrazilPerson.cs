using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.ValueObjects;
using DomainDrivenDesign.ValueObjects.Brazil;

namespace DomainDrivenDesign.Entities;

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
