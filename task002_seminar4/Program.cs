// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Эта программа принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine(" ");

Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());


int summary(int num)
{
    int sum = 0;

    while (num > 0)
    {
        int i = num % 10;
        num = num / 10;
        sum = sum + i;
    }

    return sum;
}

Console.WriteLine("Сумма цифр в числе равна " + summary(num));

