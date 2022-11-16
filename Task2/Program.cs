/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int number = ReadInt("Введите число: ");
if (number<100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (number>99 && number<1000)
{
    Console.WriteLine(number%10);
}
else
{
    while(number>=1000)
    {
        number = number/10;
    }
    Console.WriteLine(number%10);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}