// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum: " + Sum(a, b));
Console.ReadKey();
static int Sum(int a, int b)
{
    return a + b;
}

