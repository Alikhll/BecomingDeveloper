string name = "myname";
int age = 18;

Print(name, age);

static void Print(string name, int age)
{
    if (age < 18) //if age less than 18
    {
        Console.WriteLine(name + " is not valid!");
    }
    else if (age >= 18 && age < 99) //if age greater equal to 19 AND age less than 99
    {
        Console.WriteLine(name + " is valid!");
    }
    else //otherwise
    {
        Console.WriteLine("Out of range!");
    }
}





// --------------------------------------
// ----------- Other Samples ------------
// --------------------------------------




static void Sample(string name, int age)
{
    if (age == 10) { } // equeal
    if (age != 10) { } // not equeal
    if (age > 10) { } // greater
    if (age < 10) { } // less
    if (age >= 10) { } // greater equal
    if (age <= 10) { } // less equal
    if (age > 10 && age < 20) { } // AND
    if (age > 10 || age == -1) { } // OR


    if (name.StartsWith("a") == true) { } // if name starts with "a" (StartsWIth is a built in method applicable for strings)
    if (name.Length == 1) { } // if name length equal 1 (only one char)
    if (name == "abc") { }
    if (name != "abc") { }


    if (age == 10 || name == "abc") { } //if this applicable, otherwise check another else if
    else if (age == 20) { } //else if


    if (name == "abc") { } //if this applicable, otherwise else
    else { }
}