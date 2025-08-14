using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Entities;

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
        ZipCode = zipCode.Guard(new ArgumentNullException(nameof(zipCode)));
        Street = street.Guard(new ArgumentNullException(nameof(street)));
        Neighborhood = neighborhood;
        Number = number.Guard(new ArgumentNullException(nameof(number)));
        City = city.Guard(new ArgumentNullException(nameof(city)));
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