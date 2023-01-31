// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели (1-7)");
int num = int.Parse(Console.ReadLine());
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

if (num > 5)  Console.WriteLine($"{days[num-1]} - выходной день!");
else Console.WriteLine($"{days[num-1]} - рабочий день!");