namespace Poligon.InputOutput;

public class Directory
{
    internal void Start()
    {
      var directory =   new DirectoryInfo(@"C:\\Windows\assembly");
      if (directory.Exists)
      {

          Console.WriteLine(directory.FullName);
      }
      else
      {
          Console.WriteLine("Not found");
      }
    }
}