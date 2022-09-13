namespace Poligon.InputOutput;

public class FileTest
{
    public void CreateFile()
    {
        var file = new FileInfo(@"D:\Test.txt");
        var stream = file.Create();
        stream.Close();
        Console.WriteLine();
        file.Delete();
    }
}