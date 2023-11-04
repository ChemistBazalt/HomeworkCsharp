// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Input number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B");
int B = Convert.ToInt32(Console.ReadLine());

int Degree(int A, int B)
{
     int result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine($"{A} в степени {B} равно {result}");
        return result;
}
int res = Degree(A, B);
Console.WriteLine(res);
