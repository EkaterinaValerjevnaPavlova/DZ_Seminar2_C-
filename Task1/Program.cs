/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = ReadInt("Введите трёхзначное число: ");

if (number>99 && number<1000)
{
    Console.WriteLine(number/10%10);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}