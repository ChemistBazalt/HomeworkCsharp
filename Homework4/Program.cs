
// int [] nameArray = {11, 12, 13, 14, 15, 61, 17, 18, 19};
// // обращаемся к элементу массива: имя_массива [индекс]
// nameArray [0] = 12; //присваеваем элементу массива с инд 0 другое значение
// Console.WriteLine(nameArray[0]);

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// метод, заполнящюий случайными положительными числами
// void FillArray(int [] filledArray)
// {
//     // Заполняем массив случайными положительными трехзначными числами
//         for (int i = 0; i < filledArray.Length; i++)
//         {
//             filledArray[i] = new Random().Next(100, 999);
//             Console.WriteLine(filledArray[i]);
//         }
// }
// //метод, считающий кол-во чётных чисел
// int EvenNumbers(int [] numbers)
// {
//     int count = 0;
//         foreach (int number in numbers)
//         {
//             if (number % 2 == 0)
//             {
//                 count++;
//             }
//         }
//         return count;
// }
// int[] array = new int [4];
// FillArray(array);
// Console.WriteLine(EvenNumbers(array));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// void FillArray(int [] filledArray)
// {
//         for (int i = 0; i < filledArray.Length; i++)
//         {
//             filledArray[i] = new Random().Next(-99, 99);
//             Console.WriteLine(filledArray[i]);
//         }
// }
// int Summ(int [] arrays)
// {
//     int sum = 0;

//         for (int i = 1; i < arrays.Length; i += 2)
//         {
//             sum += arrays[i];
//         }
//     return sum;
// }
// int[] array = new int [4];
// FillArray(array);
// Console.WriteLine();
// Console.WriteLine(Summ(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
void FillArray(double [] filledArray)
{
        for (int i = 0; i < filledArray.Length; i++)
        {
            filledArray[i] = Math.Round(new Random().Next(0, 99) + new Random().NextDouble(), 2, MidpointRounding.ToEven);
            Console.WriteLine(filledArray[i]);
        }
        // Math.Round(value, )
        // 1, MidpointRounding.ToEven
}
double FindingMax(double [] max)
{
        double maxNum = max[0];
        for (int i = 1; i < max.Length; i++)
        {
            if (max[i] > maxNum)
            {
                maxNum = max[i];
            }
        }
        Console.WriteLine($"Max num is: {maxNum}");
        return maxNum;
}
double FindingMin(double [] min)
{
    double minNum = min[0];
        for (int i = 1; i < min.Length; i++)
        {
            if (min[i] < minNum)
            {
                minNum = min[i];
            }
        }
        Console.WriteLine($"Min num is: {minNum}");
        return minNum;
}


void Difference(double [] diff)
{
    var result = Math.Round(FindingMax(diff) - FindingMin(diff), 2, MidpointRounding.ToEven);
    Console.WriteLine(result);
}



double[] array = new double[4];
FillArray(array);
Console.WriteLine();
Difference(array);
