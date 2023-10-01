// 1 ЗАДАНИЕ Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.
// void SecondNumber(int num = 0)
// {
//     if (num < 100 || num > 999) Console.WriteLine("error");
//     else 
//     {
//         int secondDigit = num / 10;     
//         int res = secondDigit % 10;
//         Console.WriteLine($"Second number is {res}");
//     }
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your number is {number}");
// SecondNumber(number);

// 3 ЗАДАНИЕ Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
void Calendar(int numOfDay) 
{
    if (numOfDay > 0 && numOfDay<8)
    {
        if (numOfDay > 0 && numOfDay<=5)
        {
            Console.WriteLine("Today is day for work");
        }
        else if (numOfDay == 6)
        {
            Console.WriteLine("Today is day saturday. RELAX");
        }
        else if (numOfDay == 7)
        {
            Console.WriteLine("Today is day sunday. RELAX");
        }
    }
    else
    {
        Console.WriteLine("Enter from 1 to 7 number");
    }   
}
Console.WriteLine("Enter number of week: ");
int num = Convert.ToInt32(Console.ReadLine());
Calendar(num);