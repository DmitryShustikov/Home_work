Console.Write("Введите значение M:  ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение N:  ");
int n = int.Parse(Console.ReadLine());

int result = Accermann(m,n);

int Accermann(int m, int n){

    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Accermann(m - 1, 1);
    }
    else
    {
        return Accermann(m - 1, Accermann(m, n - 1));
    }

}
Console.WriteLine($"Результат функции Аккермана для m = {m}, n = {n}: {result}");

