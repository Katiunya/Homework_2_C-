// Задача 10.
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Input 3digits number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int result;

int SecondDigit (int second)
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

//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет