namespace DomainDrivenDesign.DomainObjects.Dto;

public class AddressDto
{
    public string ZipCode { get; init; }
    public string Street { get; init; }
    public string Number { get; init; }
    public string? Neighborhood { get; init; }
    public int CityId { get; init; }
    public string? Details { get; init; }
}