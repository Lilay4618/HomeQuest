Console.WriteLine("Задайте координаты точек в формате (х1, y1, z1) (x2, y2, z2)");
Console.Write("Введите значение х1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение х2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = 0;

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между заданными координатами = {distance}");