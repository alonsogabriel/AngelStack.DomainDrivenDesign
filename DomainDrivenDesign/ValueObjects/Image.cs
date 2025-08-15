namespace DomainDrivenDesign.ValueObjects;

public enum ImageType
{
    Unknown,
    Jpeg,
    Png,
    Svg,
    Webp,
    Bmp,
}

public record Image(ImageUrl Url, ImageType Type, long Size, ImageName Name, byte[]? Content);