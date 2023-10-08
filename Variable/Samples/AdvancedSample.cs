namespace Samples;

public class AdvancedSample
{
    public static void Advanced1()
    {
        double double1 = 1.9;
        int int1 = 10;

        // you can not implicitly convert here, if you write the code below, compiler breaks
        // int result = double1 + int1;

        // you can fix it by explicit casting
        int int_result = (int)double1 + int1; // result = 11 (decimal is ignored!)
        double double_result = double1 + int1; // now the result = 11.9 because int can be casted to double implicitly

        Console.WriteLine(double_result);
    }

    public static void Advanced2()
    {
        string string1 = "120"; // we have a string here, but we know it has integer as a value
        int int_result1 = int.Parse(string1); // we can parse string to int becomes 120

        Console.WriteLine(int_result1);

        string string2 = "a123"; //we don't have a pure string here
        //int int_result2 = int.Parse(string2); 
        // it will throw an exception because cannot parse (exception occures when something goes wrong! we'll practice it later!)
    }
}