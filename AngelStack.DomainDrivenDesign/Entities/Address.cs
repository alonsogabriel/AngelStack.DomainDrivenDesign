using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class Address : AbstractEntity
{
    protected Address() { }
    public Address(
        ZipCode zipCode,
        Street street,
        Neighborhood? neighborhood,
        AddressNumber number,
        City city,
        AddressDetails? details)
    {
        ZipCode = zipCode.Guard();
        Street = street.Guard();
        Neighborhood = neighborhood;
        Number = number.Guard();
        City = city.Guard();
        CityId = city.Id;
        Details = details;
    }
    public ZipCode ZipCode { get; protected set; }
    public Street Street { get; protected set; }
    public Neighborhood? Neighborhood { get; protected set; }
    public AddressNumber Number { get; protected set; }
    public int CityId { get; protected set; }
    public City City { get; protected set; }
    public AddressDetails? Details { get; protected set; }
}