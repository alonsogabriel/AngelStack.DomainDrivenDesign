using System.Text.RegularExpressions;

namespace DomainDrivenDesign.DomainObjects.Validators;

public static partial class CpfValidator
{
    private static readonly IEnumerable<Func<string, bool>> ValidationPipe = [
        ValidateFormat, ValidateEqualDigits, ValidateVerifierDigits];
    public static bool Validate(string cpf)
    {
        if (string.IsNullOrEmpty(cpf))
        {
            throw new ArgumentException("Cpf can not be null or empty.", nameof(cpf));
        }
        cpf = new string([.. cpf.Where(char.IsDigit)]);

        return ValidationPipe.All(val => val.Invoke(cpf));
    }

    public static bool ValidateFormat(string cpf)
    {
        return CpfRegex().IsMatch(cpf);
    }

    public static bool ValidateEqualDigits(string cpf)
    {
        return cpf.Distinct().Count() > 1;
    }

    public static bool ValidateVerifierDigits(string cpf)
    {
        var partial = cpf[..9];
        int firstDigit = CalculateVerifierDigit(partial);
        var secondDigit = CalculateVerifierDigit(partial + firstDigit);

        return cpf.Equals(partial + firstDigit + secondDigit);
    }

    public static int CalculateVerifierDigit(string partialCpf)
    {
        if (partialCpf.Length is not (9 or 10))
        {
            var message = $"Partial cpf must have 9 or 10 digits. Length was {partialCpf.Length}.";
            throw new ArgumentException(message, nameof(partialCpf));
        }

        int factor = partialCpf.Length + 1;
        int sum = 0;

        foreach (var digit in partialCpf)
        {
            int value = digit - '0';
            sum += factor * value;
            factor--;
        }

        int remainder = sum % 11;
        return remainder < 2 ? 0 : 11 - remainder;
    }

    [GeneratedRegex("^[0-9]{11}$", RegexOptions.Compiled | RegexOptions.Singleline)]
    public static partial Regex CpfRegex();
}
