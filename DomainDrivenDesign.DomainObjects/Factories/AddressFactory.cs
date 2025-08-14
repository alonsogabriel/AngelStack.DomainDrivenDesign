using DomainDrivenDesign.DomainObjects.Dto;
using DomainDrivenDesign.DomainObjects.Entities;
using DomainDrivenDesign.DomainObjects.ValueObjects;

namespace DomainDrivenDesign.DomainObjects.Factories;

public static class AddressFactory
{
    public static Address FromDto(AddressDto data)
    {
        return new Address(
            new ZipCode(data.ZipCode),
             new Street(data.Street),
             GetNeighborhood(data.Neighborhood),
             new AddressNumber(data.Number),
             data.CityId,
             GetDetails(data.Details));
    }

    private static Neighborhood? GetNeighborhood(string? neighborhood)
    {
        return neighborhood is null ?
            null :
            new Neighborhood(neighborhood);
    }

    private static AddressDetails? GetDetails(string? details)
    {
        return details is null ?
            null :
            new AddressDetails(details);
    }
}
