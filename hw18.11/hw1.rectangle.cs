using System;

class Rectangle : Point
{
    protected int w;
    protected int h;

    public Rectangle(string c, bool visible, int w, int h) : base(c, visible)
    {
        this.w = w;
        this.h = h;
    }

    public int CalculateArea()
    {
        return w * h;
    }
    public void Hor(int d)
    {
        Console.WriteLine("двигаем прямоугольник по горизонтали на расстояние: {0}", d);
    }

    public void Vert(int d)
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
        Console.WriteLine("прямоугольник - цвет: {0}, Visible: {1}", c, visible);
    }
}
