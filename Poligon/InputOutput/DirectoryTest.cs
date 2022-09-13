namespace Poligon.InputOutput;

public class DirectoryTest
{
    internal void Start()
    {
      var directory =   new DirectoryInfo(@"C:\\Windows\assembly");
   
      if (directory.Exists)
      {
          Directory.Delete(@"C:\\Windows\assembly");
          Console.WriteLine(directory.FullName);
      }
      else
      {
          Console.WriteLine("Not found");
      }
    }
}