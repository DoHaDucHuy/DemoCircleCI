// See https://aka.ms/new-console-template for more information
using System.Reflection;
string strFormat = "Hello {0}, welcome to {1}!";
string strName = "Huy";
string strPlace = "CircleCI";

Console.WriteLine(string.Format(strFormat, strName, strPlace));
Console.ReadKey();


