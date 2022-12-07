// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
int size = NumberSize(a);
Summa (a, size);

int NumberSize(int a)
{
    int size = 0;
    while (a > 0)
    {
        a /= 10;
        size++;
    }
    return size;
}



void Summa(int a, int size)
{
   
    int sum = 0;
    for (int i = 1; i <= size; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine(sum);
}
