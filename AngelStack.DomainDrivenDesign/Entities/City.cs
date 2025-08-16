using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class City : AbstractEntity<int>
{
    protected City() { }
    public City(Region region, CityName name)
    {
        Region = region ?? throw new ArgumentNullException(nameof(region));
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    public CityName Name { get; protected set; }
    public int RegionId { get; protected set; }
    public Region Region { get; protected set; }
    public int CountryId => Region.CountryId;
    public Country Country => Region.Country;
}
