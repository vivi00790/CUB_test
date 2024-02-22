namespace ConsoleApp1;

public class CSharpQ3
{
    public static string HideDigitsUntilLastFourDigits(string creditCardNumber)
    {
        if (creditCardNumber.Length is not (12 or 16))
            throw new ArgumentException("Credit card number must be 12 or 16 digits long");

        return string.Concat(Enumerable.Repeat("****-", creditCardNumber.Length / 4 - 1))
               + creditCardNumber[^4..];
    }
}