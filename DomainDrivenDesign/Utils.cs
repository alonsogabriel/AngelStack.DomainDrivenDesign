using System.Reflection;
using AngelStack.Common.Guards;
using AngelStack.Common.Strings;

namespace DomainDrivenDesign;

internal static class Utils
{
    public static bool IsRequired(this Type type)
    {
        return type.Guard().GetCustomAttribute<Required>()?.Value ?? false;
    }

    public static int? GetMinLength(this Type type)
    {
        return type.Guard().GetCustomAttribute<MinLength>()?.Value;
    }

    public static int? GetMaxLength(this Type type)
    {
        return type.Guard().GetCustomAttribute<MaxLength>()?.Value;
    }

    public static string? GetRegularExpression(this Type type)
    {
        return type.Guard().GetCustomAttribute<RegularExpression>()?.Value;
    }
}
