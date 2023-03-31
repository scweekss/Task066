// Задача 66: 
//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 


//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число N");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int number2 = int.Parse(Console.ReadLine());

static extern int number3(int num1, int num2);
{
    if (number1 > number2)
    {
       return number1;
    }
    else
    {
        return 
        number2 + number3 (number2 + 1, number1);
    }
}
Console.Write($"Сумма {number3(number2, number1)}");
