//Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.


Console.WriteLine("Введите число");
double num = Convert.ToDouble(Console.ReadLine());
int i = 0;
int n = IntegerNumber(num);
QuanNum(n);
int IntegerNumber(double num)
{
    int n = (int)num;
    while (n != num)
    {
        num *= 10;
        n = (int)num;
    }
    return n;
}

void QuanNum(int n)
{
    while (n > 0)
    {
        n /= 10;
        i++;
    }
    System.Console.WriteLine($"{i}");
}
