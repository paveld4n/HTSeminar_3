// Получить две точки и найти расстояние между ними в 3D
Console.WriteLine("Введите координаты первой точки");
bool PointAX = int.TryParse(Console.ReadLine(), out int ax);
bool PointAY = int.TryParse(Console.ReadLine(), out int ay);
bool PointAZ = int.TryParse(Console.ReadLine(), out int az);

Console.WriteLine("Введите координаты второй точки");
bool PointBX = int.TryParse(Console.ReadLine(), out int bx);
bool PointBY = int.TryParse(Console.ReadLine(), out int by);
bool PointBZ = int.TryParse(Console.ReadLine(), out int bz);

if(!PointAX || !PointAY || !PointAZ || !PointBX || !PointBY || !PointBZ)
{
    Console.WriteLine("Ошибка! Вы ввели не то! ПереВВедите!");
    return;
}

double Res = Distanse(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками = {Res}");

double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return dist;
}