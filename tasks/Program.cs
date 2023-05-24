// Задача 1. Задайте массив, заполненный 12-ю случайными числами в диапазоне от -9 до 9. 
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
//     return newArray;
// }

// void PrintArray(int[] arrayExample)
// {
//     int size = arrayExample.Length;
//     for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
//     Console.WriteLine();
// }

// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPos = sumPos + array[i];
//         else sumNeg = sumNeg + array[i];
//     }
//     Console.WriteLine($"Сумма положительных элементов массива равна {sumPos}." + 
//     $" Сумма отрицательных элементов массива равна {sumNeg}.");
// }

// Console.WriteLine("Введите размер массива: ");
// int array_size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение в ячейке: ");
// int min_value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение в ячейке: ");
// int max_value = Convert.ToInt32(Console.ReadLine());
// int[] userArray = CreateRandomArray(array_size, min_value, max_value);
// PrintArray(userArray);
// PosNegSum(userArray);


// Задача 2. Напишите программу изменения элемента массива. Положительные на отрицательные и наоборот. 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
    return newArray;
}

void PrintArray(int[] arrayExample)
{
    int size = arrayExample.Length;
    for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
    Console.WriteLine();
}

int[] InvertArray(int[] array)
{
    int size = array.Length;
    int[] invertArray = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        invertArray[i] = -1*array[i];
    }
    return invertArray;
}

Console.WriteLine("Введите размер массива: ");
int array_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение в ячейке: ");
int min_value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение в ячейке: ");
int max_value = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateRandomArray(array_size, min_value, max_value);
Console.Write("Исходный массив:  ");
PrintArray(userArray);
int[] resultArray = InvertArray(userArray);
Console.Write("Инвертированный массив:  ");
PrintArray(resultArray);