// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());
Stepen (a, b);
void Stepen (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


