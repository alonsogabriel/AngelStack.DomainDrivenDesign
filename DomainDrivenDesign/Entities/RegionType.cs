using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class RegionType : AbstractEntity<int>
{
    protected RegionType() { }
    public RegionType(RegionTypeName name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    public RegionTypeName Name { get; protected set; }
}