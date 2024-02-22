namespace ConsoleApp1;

public class CSharpQ1
{
    public static decimal[] ToDecimalThenSortDesc(IEnumerable<string> args)
    {
        if (!args.Any())
        {
            return Array.Empty<decimal>();
        }

        try
        {
            var amounts = args.Select(amount => amount == "-"
                ? 0.0m
                : decimal.Parse(amount) * 0.33m).ToArray();
            Array.Sort(amounts, (x, y) => y.CompareTo(x));

            return amounts;
        }
        //示例：客制化例外可以幫助添加更多的錯誤訊息(如在業務情境需添加tracecode或內部錯誤代碼)，並同時保留原始例外資訊
        catch (FormatException e)
        {
            throw new ConvertStringToDecimalException("ERR01: Invalid input, not able to convert", e);
        }
        catch (ArgumentNullException e)
        {
            throw new ConvertStringToDecimalException("ERR02: Input contains null", e);
        }
    }
}