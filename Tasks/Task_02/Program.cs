// По двум заданным числам проверять является ли одно квадратом другого

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int sq1 = num1 / num2;
int sq2 = num2 / num1;

if (sq1 == num2) Console.WriteLine($"{num1} является квадратом {num2}");
else if (sq2 == num1) Console.WriteLine($"{num2} является квадратом {num1}");
else
{
    if (num1 > num2) Console.WriteLine($"{num1} не является квадратом {num2}");
    else Console.WriteLine($"{num2} не является квадратом {num1}");
}