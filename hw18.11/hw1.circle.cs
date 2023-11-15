using System;
class Circle : Point
{
    protected double r;
    public Circle(string c, bool visible, double r) : base(c, visible)
    {
        this.r = r;
    }
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(r, 2);
    }
    public void Hor(int d)
    {
        Console.WriteLine("двигаем круг по горизонтали на расстояние: {0}", d);
    }
    public override void change(string newColor)
    {
        c = newColor;
        Console.WriteLine("меняем цвет на: {0}", c);
    }
    public void Vert(int d)
    {
        Console.WriteLine("двигаем круг по вертикали на расстояние: {0}", d);
    }
    public override void status()
    {
        Console.WriteLine("круг - цвет: {0}, Visible: {1}", c, visible);
    }
}