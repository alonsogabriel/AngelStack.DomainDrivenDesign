using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class Country : AbstractEntity<int>
{
    protected Country() { }
    public Country(CountryName name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    public CountryName Name { get; protected set; }
}
