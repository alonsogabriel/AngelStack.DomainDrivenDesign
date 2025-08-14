using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Entities;

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
        ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        Street = street ?? throw new ArgumentNullException(nameof(street));
        Neighborhood = neighborhood;
        Number = number ?? throw new ArgumentNullException(nameof(number));
        City = city ?? throw new ArgumentNullException(nameof(city));
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