namespace Methods;
/*
public partial class TroubleShootingSample
{
    public static void Trouble3()
    {
        // error CS0122: 'AnotherClass.PrintName(string)' is inaccessible due to its protection level
        // 'PrintName' method inside the 'AnotherClass' is not public therefore we are not allowed to call it 
        AnotherClass.PrintName("myname");
    }
}
*/

public class AnotherClass
{
    static void PrintName(string name)
    {
        Console.WriteLine("Name: " + name);
    }
}
