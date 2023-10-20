namespace Conditions;

public class BasicSample
{
    public static void Sample1(int age)
    {
        if (age == 10) { } // equeal
        if (age != 10) { } // not equeal
        if (age > 10) { } // greater
        if (age < 10) { } // less
        if (age >= 10) { } // greater equal
        if (age <= 10) { } // less equal
        if (age > 10 && age < 20) { } // AND
        if (age > 10 || age == -1) { } // OR
    }


    // ------------------------------------
    // ------------------------------------
    // ------------------------------------


    public static void Sample2(string name)
    {
        if (name.StartsWith("a") == true) { } // if name starts with "a" (StartsWIth is a built in method applicable for strings)
        if (name.Length == 1) { } // if name length equal 1 (only one char)
        if (name == "abc") { }
        if (name != "abc") { }
    }

    public static void Sample3(int age, string name)
    {
        if (age == 10 || name == "abc") { } //if this applicable, otherwise check another else if
        else if (age == 20) { } //else if


        if (name == "abc") { } //if this applicable, otherwise else
        else { }
    }
}