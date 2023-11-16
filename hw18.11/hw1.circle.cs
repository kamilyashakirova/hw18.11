using System;
class Circle : Point
{
    protected double r;
    public Circle(string c, bool v, double r) : base(c, v)
    {
        this.r = r;
    }
    public double area()
    {
        return Math.PI * Math.Pow(r, 2);
    }
    public void hor(int d)
    {
        Console.WriteLine("двигаем круг по горизонтали на расстояние: {0}", d);
    }
    public override void change(string newColor)
    {
        c = newColor;
        Console.WriteLine("меняем цвет на: {0}", c);
    }
    public void vert(int d)
    {
        Console.WriteLine("двигаем круг по вертикали на расстояние: {0}", d);
    }
    public override void status()
    {
        Console.WriteLine("круг - цвет: {0}, видимость: {1}", c, v);
    }
}
