using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Entities;

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
        ZipCode = zipCode.Guard();
        Part1 = part1.Guard();
        Part2 = part2;
        Part3 = part3;
        Number = number.Guard();
        City = city.Guard();
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
