using System;

class Rectangle : Point
{
    protected int w;
    protected int h;

    public Rectangle(string c, bool v, int w, int h) : base(c, v)
    {
        this.w = w;
        this.h = h;
    }

    public int area()
    {
        return w * h;
    }
    public void hor(int d)
    {
        Console.WriteLine("двигаем прямоугольник по горизонтали на расстояние: {0}", d);
    }

    public void vert(int d)
    {
        Console.WriteLine("двигаем прямоугольник по вертикали на расстояние: {0}", d);
    }
    public override void change(string newColor)
    {
        c = newColor;
        Console.WriteLine("меняем цвет на: {0}", c);
    }

    public override void status()
    {
        Console.WriteLine("прямоугольник - цвет: {0}, Visible: {1}", c, v);
    }
}
