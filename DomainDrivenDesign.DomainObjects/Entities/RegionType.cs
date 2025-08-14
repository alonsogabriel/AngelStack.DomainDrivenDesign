using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

public class RegionType : AbstractEntity<int>
{
    public RegionTypeName Name { get; set; }
}