using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class RegionType : AbstractEntity<int>
{
    protected RegionType() { }
    public RegionType(RegionTypeName name)
    {
        Name = name.Guard();
    }
    public RegionTypeName Name { get; protected set; }
}