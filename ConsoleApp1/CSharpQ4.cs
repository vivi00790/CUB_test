public class CSharpQ4
{
    public static string ConvertToString<T>(T input)
    {
        if (input == null)
        {
            throw new InvalidOperationException("Input cannot be null");
        }
        return typeof(T) != typeof(DateTime) ? input.ToString() : ((DateTime)(object)input).ToString("yyyy/MM/dd");
    }
}