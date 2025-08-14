using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

public class Country : AbstractEntity<int>
{
    protected Country() { }
    public Country(CountryName name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    public CountryName Name { get; protected set; }
}
