Console.Write("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
Console.Write("Введите элементы массива:  ");
FillArray(array, 0);

void FillArray(int[] arr, int index){

    if (index < arr.Length)
    {
        Console.Write($"Элемент {index + 1}:  ");
        arr[index] = int.Parse(Console.ReadLine());
        FillArray(arr, index + 1);
    }
   
}
void PrintArrayRevers(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index]);
        PrintArrayRevers(arr, index - 1);

    }
}
Console.Write("Вывод элементов массива:  ");
PrintArrayRevers(array, array.Length - 1);