// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine());

        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Введено неверное число. Попробуйте еще раз.");
            return;
        }

        int fifthDigit = number % 10;
        int fourthDigit = (number / 10) % 10;
        int thirdDigit = (number / 100) % 10;
        int secondDigit = (number / 1000) % 10;
        int firstDigit = (number / 10000) % 10;

        if (firstDigit == fifthDigit && secondDigit == fourthDigit)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }
}
