using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class Region : AbstractEntity<int>
{
    private readonly List<Region> _regions = [];
    private readonly List<City> _cities = [];

    protected Region() { }

    protected Region(int id) : base(id) { }

    public Region(Country country, RegionType type, RegionName name, RegionAlias? alias = null, Region? parent = null)
    {
        Country = country.Guard();
        CountryId = country.Id;
        Type = type.Guard();
        TypeId = type.Id;
        Name = name.Guard();
        Parent = parent;
        ParentId = parent?.Id;
        Alias = alias;
    }

    public int CountryId { get; protected set; }
    public Country Country { get; protected set; }
    public int? ParentId { get; protected set; }
    public Region? Parent { get; protected set; }
    public RegionName Name { get; protected set; }
    public RegionAlias? Alias { get; protected set; }
    public int TypeId { get; protected set; }
    public RegionType Type { get; protected set; }
    public IReadOnlyList<Region> Regions => _regions;
    public IReadOnlyList<City> Cities => _cities;
    public IEnumerable<City> AllCities => GetCitiesRecursevely(this);

    protected static IEnumerable<City> GetCitiesRecursevely(Region region)
    {
        foreach (var city in region._cities)
        {
            yield return city;
        }

        foreach (var childRegion in region._regions)
        {
            foreach (var city in GetCitiesRecursevely(childRegion))
            {
                yield return city;
            }
        }
    }
}