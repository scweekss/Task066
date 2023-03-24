//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;

if (length == 3) 
{
	int a = ( number/10 ) % 10;
	Console.WriteLine("Второе число это " + a);

}
else
{
    Console.WriteLine("Нет третьего числа");
}

