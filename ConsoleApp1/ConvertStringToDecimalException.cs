namespace ConsoleApp1;

public class ConvertStringToDecimalException : Exception 
{
    public ConvertStringToDecimalException(string message) : base(message)
    {
    }
    
    public ConvertStringToDecimalException(string message, Exception innerException) : base(message, innerException)
    {
    }
    
    public ConvertStringToDecimalException()
    {
    }
}