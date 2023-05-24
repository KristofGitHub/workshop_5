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

// int[] InvertArray(int[] array)
// {
//     int size = array.Length;
//     int[] invertArray = new int[size];
//     for(int i = 0; i < array.Length; i++)
//     {
//         invertArray[i] = -1*array[i];
//     }
//     return invertArray;
// }

// Console.WriteLine("Введите размер массива: ");
// int array_size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение в ячейке: ");
// int min_value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение в ячейке: ");
// int max_value = Convert.ToInt32(Console.ReadLine());
// int[] userArray = CreateRandomArray(array_size, min_value, max_value);
// Console.Write("Исходный массив:  ");
// PrintArray(userArray);
// int[] resultArray = InvertArray(userArray);
// Console.Write("Инвертированный массив:  ");
// PrintArray(resultArray);


// Задача 3. Запросить у пользователя число и определить, присутствует ли это число в массиве.

// Console.WriteLine("Введите размер массива: ");
// int array_size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение в ячейке: ");
// int min_value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение в ячейке: ");
// int max_value = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число, наличие которого нужно проверить в массиве: ");
// int find_value = Convert.ToInt32(Console.ReadLine());
// int[] userArray = CreateRandomArray(array_size, min_value, max_value);
// Console.Write("Исходный массив:  ");
// PrintArray(userArray);
// FindNum(userArray, find_value);

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

// void FindNum(int[] array, int number)
// {
//     bool finded = false;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) finded  = true;
//     }
//     if (finded == true) Console.WriteLine($"Число {number} присутствует в массиве.");
//     else Console.WriteLine($"Число {number} в массиве отсутствует.");
// }


// Задача 4. Задайте одномерный массив из 123 элементов. Найдите количество элементов, значения которых
// лежат внутри диапазона [10;99].

int array_size = 123;
int min_value = 0;
int max_value = 199;
int[] userArray = CreateRandomArray(array_size, min_value, max_value);
//PrintArray(userArray);
FindNum(userArray);

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int index = 0; index < size; index++){newArray[index] = new Random().Next(minValue, maxValue + 1);}
    return newArray;
}

// void PrintArray(int[] arrayExample)
// {
//     int size = arrayExample.Length;
//     for(int index = 0; index < size; index++){Console.Write(arrayExample[index] + " ");}
//     Console.WriteLine();
// }

void FindNum(int[] array)
{
    int finded = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10)&&(array[i]<=99)) finded++;
    }
    Console.WriteLine($"Количество элементов со значениями в диапазоне [10;99] в массиве равно {finded}.");
}
