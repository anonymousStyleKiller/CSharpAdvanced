namespace Poligon.GC;

public class Destructor
{
    ~Destructor()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }  
    }
}