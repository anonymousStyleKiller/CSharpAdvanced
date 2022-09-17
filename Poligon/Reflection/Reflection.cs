using System.Reflection;

namespace Poligon.Reflection;

public static class Reflection
{
    public static void Main()
    {
        var myClass = new Class1();
        Type type;
        type = myClass.GetType();
        Console.WriteLine(type.Namespace);
    }

    static void ListMethods(Class1 cl)
    {
        Type t = cl.GetType();
        MethodInfo[] mi = t.GetMethods(BindingFlags.Instance
                                       | BindingFlags.Static
                                       | BindingFlags.Public
                                       | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

        foreach (MethodInfo m in mi)
            Console.WriteLine("Method: {0}", m.Name);
    }

    static void ListFields(Class1 cl)
    {
        Type t = cl.GetType();
        FieldInfo[] fi =
            t.GetFields(BindingFlags.Instance
                        | BindingFlags.Static
                        | BindingFlags.Public
                        | BindingFlags.NonPublic);

        foreach (FieldInfo f in fi)
            Console.WriteLine("Field: {0}", f.Name);
    }

    static void ListProps(Class1 cl)
    {
        Type t = cl.GetType();
        PropertyInfo[] pi = t.GetProperties();

        foreach (PropertyInfo p in pi)
            Console.WriteLine("{0}", p.Name);
    }

    static void ListInterfaces(Class1 cl)
    {
    
        Type t = cl.GetType();

        Type[] it = t.GetInterfaces();

        foreach (Type i in it)
            Console.WriteLine("{0}", i.Name);
    }
    
    static void ListConstructors(Class1 cl)
    {

        Type t = cl.GetType();
        ConstructorInfo[] ci = t.GetConstructors();

        foreach (ConstructorInfo m in ci)
            Console.WriteLine("Constructor: {0}", m.Name);
    }

}

public class Class1
{
}