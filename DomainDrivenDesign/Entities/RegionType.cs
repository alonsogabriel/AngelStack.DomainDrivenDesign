using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Entities;

public class RegionType : AbstractEntity<int>
{
    protected RegionType() { }
    public RegionType(RegionTypeName name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    public RegionTypeName Name { get; protected set; }
}