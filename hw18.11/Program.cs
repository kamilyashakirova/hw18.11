using System;
class Program
{
    static void Main()
    {
        //Упражнение 10.1.
        ICipher a = new ACipher();
        ICipher b = new BCipher();
        Console.WriteLine("упр 10.1. создать интерфейс ICipher, который определяет методы поддержки шифрования строк");
        string into = "dont stress about dumn shit";
        string eA = a.e(into);
        Console.WriteLine("ACipher:\nзашифровано: {0}", eA);
        string dA = a.d(eA);
        Console.WriteLine("расшифровано: {0}", dA);
        string eB = b.e(into);
        string dB = b.d(eB);
        Console.WriteLine("BCipher:\nзашифровано: " + eB);
        //Домашнее задание 10.1.
        Console.WriteLine("дз 10.1. создать класс Figure для работы с геометрическими фигурами");
        Console.WriteLine("расшифровано: " + dB);
        Point point = new Point("pink", true);
        Circle circle = new Circle("purple", true, 3);
        Rectangle rectangle = new Rectangle("gray", true, 30, 40);
        point.hor(22);
        circle.hor(23);
        rectangle.vert(42);
        rectangle.hor(21);
        point.vert(2);
        point.change("red");
        circle.change("black");
        rectangle.change("blue");
        point.status();
        circle.status();
        rectangle.status();
        double carea = circle.area();
        double rarea = rectangle.area();
        Console.WriteLine("площадь окружности: " + carea);
        Console.WriteLine("площадь прямоугольника: " + rarea);
    }
}
