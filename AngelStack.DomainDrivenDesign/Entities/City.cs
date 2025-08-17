using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class City : AbstractEntity<int>
{
    protected City() { }
    public City(Region region, CityName name)
    {
        Region = region.Guard();
        Name = name.Guard();
    }
    public CityName Name { get; protected set; }
    public int RegionId { get; protected set; }
    public Region Region { get; protected set; }
    public int CountryId => Region.CountryId;
    public Country Country => Region.Country;
}
