using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

public class Region<T> : AbstractEntity<T>
{
    private readonly List<Region<T>> _regions = [];
    private readonly List<City> _cities = [];

    protected Region() { }

    protected Region(T id) : base(id) { }

    public Region(int typeId, string name, string? alias = null, int? parentId = null)
    {
        TypeId = typeId;
        Name = new RegionName(name);
        ParentId = parentId;
        if (alias != null)
        {
            Alias = new RegionAlias(alias);
        }
    }

    public int? ParentId { get; set; }
    public RegionName Name { get; set; }
    public RegionAlias? Alias { get; set; }
    public int TypeId { get; set; }
    public RegionType Type { get; set; }
    public IReadOnlyList<Region<T>> Regions => _regions;
    public IReadOnlyList<City> Cities => _cities;
    public IEnumerable<City> AllCities => GetCitiesRecursevely(this);

    protected static IEnumerable<City> GetCitiesRecursevely(Region<T> region)
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

public class Region : Region<int>
{
    public Region() { }
    public Region(int typeId, string name, string? alias = null, int? parentId = null) :
        base(typeId, name, alias, parentId)
    {
    }
}