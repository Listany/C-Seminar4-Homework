// программа принимает на вход число и выдает сумму его цифр

int GetDigitSum(int num)
{
    num = Math.Abs(num);
    int tempDigit = 0;
    int sum = 0;

    while(num > 0)
    {
        tempDigit= num% 10;
        num = num / 10;
        sum= sum + tempDigit;
    }

    return sum;
}

Console.WriteLine("Введите число: ");

int numInput = 0;

try
{
    numInput = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Вы ввели некорректные данные");
}

int result = GetDigitSum(numInput);
Console.WriteLine($"Сумма цифр введенного числа равна {result}");

Console.ReadLine();

