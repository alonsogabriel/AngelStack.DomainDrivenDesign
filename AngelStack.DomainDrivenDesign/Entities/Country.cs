using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class Country : AbstractEntity<int>
{
    protected Country() { }
    public Country(
        CountryName name,
        CountryIsoA2? isoA2 = null,
        CountryIsoA3? isoA3 = null,
        CountryIsoNumber? isoNumber = null)
    {
        Name = name.Guard();
        IsoA2 = isoA2;
        IsoA3 = isoA3;
        IsoNumber = isoNumber;
    }

    public CountryName Name { get; protected set; }
    public CountryIsoA2? IsoA2 { get; protected set; }
    public CountryIsoA3? IsoA3 { get; protected set; }
    public CountryIsoNumber? IsoNumber { get; protected set; }
}
