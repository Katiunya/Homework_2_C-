// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Input 3digits number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int result;

int SecondDigit (int number)
{
    int secondNum = (user_number % 100) / 10;
    return secondNum;
}

if (user_number > 99 && user_number < 1000)
{
    result = SecondDigit(user_number);
    Console.WriteLine($"The second digit is {result}");
}
else
    Console.WriteLine("ERROR, your number is not 3digits");

*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Input your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int result;

int ThirdDigit (int number)
{
    while (user_number > 1000)
    {
        user_number = user_number / 10;
    }
    int thirdNum = user_number % 10;
    return thirdNum;
}

if (user_number > 99)
{
    result = ThirdDigit(user_number);
    Console.WriteLine($"The third digit is {result}");
}
else
    Console.WriteLine("There is no third digit");




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
/*
Console.Write("Input your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 1 && user_number < 6)
    Console.WriteLine("No");
else if (user_number == 6 || user_number == 7)
    Console.WriteLine("Yes");
else
    Console.WriteLine("ERROR, this is not day of week.");
*/
// В этой задаче как-то с методом не задалось. Мне кажется, что здесь 
// и без него все хорошо получается)))    