//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Input number A");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B");
// int numB = Convert.ToInt32(Console.ReadLine());

// if (numA > numB)
// {
//     Console.WriteLine($"{numA} is bigger than {numB}");
// }
// else
// {
//     Console.WriteLine($"{numB} is bigger than {numA}");
// }

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Input number A");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number C");
// int numC = Convert.ToInt32(Console.ReadLine());

// int max = numA;
// if (max < numB)
// {
//     max = numB;
//     if (max > numC)
//     {
//         Console.WriteLine($"Max is {numB}");
//     }
//     else
//     {
//         max = numC;
//         Console.WriteLine($"Max is {numC}");
//     }
// }
// else if (max < numC)
// {
//     Console.WriteLine($"Max is {numC}");
// }
// else
// {
//     Console.WriteLine($"Max is {numA}");
// }

//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = num % 2;
// if (res == 0)
// {
//     Console.WriteLine($"{num} divides 2");
// }
// else
// {
//     Console.WriteLine($"{num} NOT divides 2");
// }

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i<n; i+=2 )
{
    Console.Write($"{i} ");
} 

