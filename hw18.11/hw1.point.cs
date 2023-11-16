using System;
class Point : Figure, movable
{
    public Point(string c, bool v) : base(c, v)
    {
    }

    public void Hor(int d)
    {
        Console.WriteLine("двигаем точку по горизонтали на расстояние: {0}", d);
    }

    public void Vert(int d)
    {
        Console.WriteLine("двигаем точку по вертикали на расстояние: {0}", d);
    }

    public override void change(string newColor)
    {
        c = newColor;
        Console.WriteLine("меняем цвет на: {0}", c);
    }

    public override void status()
    {
        Console.WriteLine("точка - её цвет: {0}, видимая: {1}", c, v);
    }
}
