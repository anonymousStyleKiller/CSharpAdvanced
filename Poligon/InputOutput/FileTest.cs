namespace Poligon.InputOutput;

public class FileTest
{
    public void CreateFile()
    {
        var file = new FileInfo(@"C:\Test.txt");
        var stream = file.Create();
        stream.Close();
        Console.WriteLine();
        file.Delete();
    }

    public void CreateFileExt()
    {
        var file = new FileInfo(@"C:\Test.txt");
        var stream = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        stream.Close();
        file.Delete();
    }

    public void CreateFileStream()
    {
        var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        for (int i = 0; i < 256; i++)
        {
            stream.WriteByte((byte)i);
        }

        Console.WriteLine(stream.Position);
        stream.Position = 100;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(" " + stream.ReadByte());
        }
    }

    public void CreateText()
    {
        var file = new FileInfo(@"C:\Test.txt");
       var writer = file.CreateText();
       writer.WriteLine("Anton");
       writer.WriteLine(writer.NewLine);
       writer.WriteLine("Kharchenko");
    }
    
    public void Copy()
    {
        var file = new FileInfo(@"D:\Test.txt");
        file.Create();
        var copy = file.CopyTo(@"D:\Projects\Test.txt");
        Console.WriteLine("Success");
    }

    public void DriveI()
    {
       var d =  DriveInfo.GetDrives();
       foreach (var driveInfo in d)
       {
           Console.WriteLine(driveInfo.Name);
       }
    }
    
    
}