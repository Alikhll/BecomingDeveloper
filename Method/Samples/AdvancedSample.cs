namespace Methods;

public class AdvancedSample
{
    public static void Advanced1()
    {
        //here we try to do some nice tricks
        //call the fundtion "GetFullName" and pass all parameters and directly retrun the result ino "Conosle.WriteLine"
        //the result will be printed
        Console.WriteLine(GetFullName("myFirstName", "myLastName"));
    }

    private static string GetFullName(string fName, string lName)
    {
        return fName + " - " + lName;
    }
}