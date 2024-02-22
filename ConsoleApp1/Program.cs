using System;
using ConsoleApp1;

Console.WriteLine("C# question 1:");
var amounts = CSharpQ1.ToDecimalThenSortDesc(new[] { "1.2", "1.4", "0.2", "-", "-0.005" });
Console.WriteLine(string.Join(", ", amounts));

Console.WriteLine("C# question 3:");
Console.WriteLine("0123456789012345");
Console.WriteLine(CSharpQ3.HideDigitsUntilLastFourDigits("0123456789012345"));
Console.WriteLine("012345678901");
Console.WriteLine(CSharpQ3.HideDigitsUntilLastFourDigits("012345678901"));

Console.WriteLine("C# question 4:");
Console.WriteLine("string 888");
Console.WriteLine(CSharpQ4.ConvertToString("888"));
Console.WriteLine("int 888");
Console.WriteLine(CSharpQ4.ConvertToString(888));
Console.WriteLine("DateTime 2023/07/30");
Console.WriteLine(CSharpQ4.ConvertToString(new DateTime(2023,7,30)));