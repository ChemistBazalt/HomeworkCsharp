// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Input number A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B");
// int B = Convert.ToInt32(Console.ReadLine());

// int Degree(int A, int B)
// {
//      int result = 1;

//         for (int i = 1; i <= B; i++)
//         {
//             result *= A;
//         }

//         Console.WriteLine($"{A} в степени {B} равно {result}");
//         return result;
// }
// int res = Degree(A, B);
// Console.WriteLine(res);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Input integer number");
// int input = Convert.ToInt32(Console.ReadLine());

// int CalculateSumOfDigits(int input)
//     {
//         int sum = 0;
//         while (input != 0)
//         {
//             sum += input % 10;
//             input /= 10;
//         }
//         return sum;
//     }

// int res = CalculateSumOfDigits(input); 
// Console.WriteLine(res);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8]; 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент {0}: ", i);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
        Console.Write("Элементы массива:" );
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
Console.ReadLine( );
    