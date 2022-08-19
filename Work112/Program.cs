Console.WriteLine("Задайте координаты точек в формате (х1, х2) (y1, y2)");
Console.Write("Введите значение х1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение х2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = 0;

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между заданными координатами = {distance}");