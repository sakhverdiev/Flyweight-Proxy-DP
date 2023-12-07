using System;

interface Shape
{
    void draw();
}

public class Circle : Shape
{
    private string color;
    private int x;
    private int y;
    private int radius;

    public Circle(String color)
    {
        this.color = color;
    }

    public void setX(int x)
    {
        this.x = x;
    }

    public void setY(int y)
    {
        this.y = y;
    }

    public void setRadius(int radius)
    {
        this.radius = radius;
    }

    // override
    public void draw()
    {
        Console.WriteLine("Color : " + color + ", x : " + x + ", y :" + y + ", radius :" + radius);
    }
}

public class ShapeFactory
{
    private static HashMap circleMap = new HashMap();

    public static Shape getCircle(string color)
    {
        Circle circle = (Circle)circleMap.get(color);

        if (circle == null)
        {
            circle = new Circle(color);
            circleMap.put(color, circle);
            Console.WriteLine("Creating circle of color : " + color);
        }
        return circle;
    }
}


//class Program { 
//    public static void Main()
//    {
//        Shape shape = new Circle();
//        Console.WriteLine("abc");
//    }
//}