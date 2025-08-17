namespace AngelStack.DomainDrivenDesign.Validators;

public static class CpfValidator
{
    public static bool Validate(string cpf)
    {
        if (string.IsNullOrEmpty(cpf))
        {
            throw new ArgumentException("Cpf can not be null or empty.", nameof(cpf));
        }

        return ValidateFormat(cpf) && ValidateEqualDigits(cpf) && ValidateVerifierDigits(cpf);
    }

    private static bool ValidateFormat(string cpf)
    {
        return RegularExpressions.CpfRegex().IsMatch(cpf);
    }

    private static bool ValidateEqualDigits(string cpf)
    {
        return cpf.Distinct().Count() > 1;
    }

    private static bool ValidateVerifierDigits(string cpf)
    {
        var partial = cpf[..9];
        int firstDigit = CalculateVerifierDigit(partial);
        var secondDigit = CalculateVerifierDigit(partial + firstDigit);

        return cpf.Equals(partial + firstDigit + secondDigit);
    }

    private static int CalculateVerifierDigit(string partialCpf)
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
}
