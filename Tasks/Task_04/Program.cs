// Найти расстояние между точками в пространстве 2D/3D
Console.Write("Выберете 2D (напишите 2) или 3D (напишите 3): ");
int osi = int.Parse(Console.ReadLine());

if (osi == 2)
{
    Console.Write("X1: ");
    double X1 = double.Parse(Console.ReadLine());
    Console.Write("Y1: ");
    double Y1 = double.Parse(Console.ReadLine());
    Console.Write("X2: ");
    double X2 = double.Parse(Console.ReadLine());
    Console.Write("Y2: ");
    double Y2 = double.Parse(Console.ReadLine());
    double result = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2));
    Console.WriteLine($"Расстояние между точкой ({X1},{Y1}) и ({X2},{Y2}) = {result}");
}
else if (osi == 3)
{
    Console.Write("X1: ");
    double X1 = double.Parse(Console.ReadLine());
    Console.Write("Y1: ");
    double Y1 = double.Parse(Console.ReadLine());
    Console.Write("Z1: ");
    double Z1 = double.Parse(Console.ReadLine());
    Console.Write("X2: ");
    double X2 = double.Parse(Console.ReadLine());
    Console.Write("Y2: ");
    double Y2 = double.Parse(Console.ReadLine());
    Console.Write("Z2: ");
    double Z2 = double.Parse(Console.ReadLine());
    double result = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
    Console.WriteLine($"Расстояние между точкой ({X1},{Y1},{Z1}) и ({X2},{Y2},{Z2}) = {result}");
}