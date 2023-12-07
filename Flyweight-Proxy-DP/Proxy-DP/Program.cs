namespace Proxy_DP;

interface Image
{
    void display();
}


public class RealImage : Image
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        loadFromDisk(fileName);
    }


    // override
    public void display()
    {   
        Console.WriteLine("Displaying " + fileName);
    }

    private void loadFromDisk(string fileName)
    {
        Console.WriteLine("Loading " + fileName);
    }
}


public class ProxyImage : Image
{
    private RealImage realImage;
    private string fileName;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }


    // override
    public void display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }
        realImage.display();
    }
}

class Program
{
    public static void Main()
    {
        Image image = new ProxyImage("abc.jpg");


        image.display();
        Console.WriteLine("image loaded from disk");


        image.display();
        Console.WriteLine("image will not be loaded from disk");
    }
}