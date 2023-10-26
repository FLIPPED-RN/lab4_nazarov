//высокий уровень, 6
Console.WriteLine("Введите x: ");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите y: ");
double y = double.Parse(Console.ReadLine());

Console.WriteLine((x >= 0 && x <= 2 && y >= -2 && y <= 2) ? "Входит" : "Не входит");