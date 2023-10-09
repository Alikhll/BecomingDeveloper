namespace Methods;

public class BasicSample
{
    public static void Sample1()
    {
        string n = "myName";

        //call a method and pass a variable (method's return is void)
        PrintNameWithParam(n);
    }

    //static method called PrintNameWithParam, get a string parameter and returns void means nothing!
    private static void PrintNameWithParam(string name)
    {
        Console.WriteLine("Name: " + name);
    }



    // ------------------------------------
    // ------------------------------------
    // ------------------------------------


    public static void Sample2()
    {
        int i1 = 2;
        int i2 = 3;

        // call a method Sum (pass parameters) and retunr the result into another variable called "sum1"
        int sum1 = Sum(i1, i2);

        Console.WriteLine(sum1);

        int sum2 = Sum(10, 20);

        Console.WriteLine(sum2);
    }


    //return type is "int" and gets two integer parameters as well
    private static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }


    // ------------------------------------
    // ------------------------------------
    // ------------------------------------


    public static void Sample3()
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