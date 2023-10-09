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

    // ------------------------------------
    // ------------------------------------
    // ------------------------------------

    public static void Advanced2()
    {
        // var can be used and the type will be inferred by the compiler!
        var fname = "abc";
        var lname = "def";

        var length = GetFullNameLength(fname, lname);

        Console.WriteLine(length);
    }

    private static int GetFullNameLength(string fName, string lName)
    {
        // var can be used and the type will be inferred by the compiler!
        // instead of 'string fullname = ...' 
        var fullname = fName + " " + lName;

        // same var but compile knows that the tpye would be 'int' 
        var fullNameLength = fullname.Length;

        return fullNameLength;
    }
}