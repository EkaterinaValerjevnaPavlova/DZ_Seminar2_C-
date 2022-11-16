/*
Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int number = ReadInt("Введите число от 1 до 7: ");

if (number>0 && number<6)
{
    Console.WriteLine("Нет");
}
else if (number<=0 || number>7)
{
    Console.WriteLine("Число не верное");
}
else
{
    Console.WriteLine("Да");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}