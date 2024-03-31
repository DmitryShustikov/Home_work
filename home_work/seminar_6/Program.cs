// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




Console.Write("Введите значение M:  ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение N:  ");
int n = int.Parse(Console.ReadLine());
void PrintNaturalNum(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + ";");
        PrintNaturalNum(m + 1, n);
    }
}
PrintNaturalNum(m, n);


