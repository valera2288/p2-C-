using System;

class Rectangle
{
    private double width;
    private double height;

    public Rectangle()
    {
        width = 3.0;
        height = 3.0;
    }

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }

    public Rectangle(Rectangle original)
    {
        width = original.width;
        height = original.height;
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Ширина прямоугольника = {width}, высота прямоугольника = {height}, площадь прямоугольника = {CalculateArea()}");
    }

    ~Rectangle()
    {
        Console.WriteLine("Удаление");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вызов конструктора без параметров");
        Rectangle rect1 = new Rectangle();
        rect1.ShowDetails();

        Console.WriteLine("\nВызов конструктора с параметрами");
        Rectangle rect2 = new Rectangle(7, 12);
        rect2.ShowDetails();

        Console.WriteLine("\nВызов конструктора копирования");
        Rectangle rect3 = new Rectangle(rect2);
        rect3.ShowDetails();

        Console.WriteLine("\nЗавершение");
    }
}
