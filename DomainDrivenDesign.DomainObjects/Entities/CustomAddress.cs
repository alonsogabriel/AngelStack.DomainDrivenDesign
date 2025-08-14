using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

public class CustomAddress : AbstractEntity
{
    protected CustomAddress() { }

    public CustomAddress(
        ZipCode zipCode,
        AddressPart part1,
        AddressPart? part2,
        AddressPart? part3,
        AddressNumber number,
        City city,
        AddressDetails? details)
    {
        ZipCode = zipCode.Guard(new ArgumentNullException(nameof(zipCode)));
        Part1 = part1.Guard(new ArgumentNullException(nameof(part1)));
        Part2 = part2;
        Part3 = part3;
        Number = number.Guard(new ArgumentNullException(nameof(number)));
        City = city.Guard(new ArgumentNullException(nameof(city)));
        CityId = city.Id;
        Details = details;
    }

    public ZipCode ZipCode { get; protected set; }
    public AddressPart Part1 { get; protected set; }
    public AddressPart? Part2 { get; protected set; }
    public AddressPart? Part3 { get; protected set; }
    public AddressNumber Number { get; protected set; }
    public int CityId { get; protected set; }
    public City City { get; protected set; }
    public AddressDetails? Details { get; protected set; }
}
