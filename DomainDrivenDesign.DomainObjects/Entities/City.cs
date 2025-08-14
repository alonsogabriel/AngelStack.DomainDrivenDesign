using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

public class City : AbstractEntity<int>
{
    public CityName Name { get; private set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }
}
