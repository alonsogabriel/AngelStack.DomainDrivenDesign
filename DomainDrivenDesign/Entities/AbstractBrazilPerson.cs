using AngelStack.Common.Guards;
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
        Cpf = cpf.Guard();
    }

    public Cpf? Cpf { get; set; }
}
