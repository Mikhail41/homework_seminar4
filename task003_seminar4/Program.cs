// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Эта программа задаёт массив из 8 элементов и выводит их на экран.");

int[] fillArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 111);
    }
    return arr;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
int[] arr = new int[8];
fillArr(arr);
PrintArray(arr);