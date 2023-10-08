namespace Samples;

public class BasicSample
{
    public static void Sample1()
    {
        string s1 = ""; // you could define whatever string here
        string s2 = "123"; // same here some random integere inside double quote
        string firstName = "fName";
        string lastName = "lName";
        string fullName = firstName + "-" + lastName; // would be "fname - lname"

        int length = fullName.Length; //length of the fullName (how many chars!)
        string convertToString = length.ToString(); //convert int to string using ToString method (built in method)

        Console.WriteLine(convertToString);
    }

    public static void Sample2()
    {
        int num1 = 1;
        int num2 = 2;
        int sum = num1 + num2; // sum
        int mul = sum * sum; // multiply
        int divide = num2 / num1; // divide
        int remainder = num2 % num1;
        int calc = (num1 + num2) / mul * 10; //mathematical experssion

        Console.WriteLine(divide);
        Console.WriteLine(remainder);
        Console.WriteLine(calc);
    }

    public static void Sample3()
    {
        double d0 = 5;
        double d1 = 1.1;
        double d2 = 2.2;
        double d3 = d1 + d2;

        bool b1 = true;
        bool b2 = false;

        Console.WriteLine(d3);
        Console.WriteLine(b1);
        Console.WriteLine(b2);
    }
}