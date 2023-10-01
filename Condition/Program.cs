string name = "myname";
int age = 18;

Print(name, age);

static void Print(string name, int age)
{
    if (age < 18)
    {
        Console.WriteLine(name + " is not valid!");
    }
    else if (age >= 18 && age < 99)
    {
        Console.WriteLine(name + " is valid!");
    }
    else
    {
        Console.WriteLine("Out of range!");
    }
}

// ----------- Other Samples ------------

static void Sample(string name, int age)
{
    if (age == 10) { }
    if (age != 10) { }
    if (age > 10) { }
    if (age < 10) { }
    if (age >= 10) { }
    if (age <= 10) { }
    if (age > 10 && age < 20) { }
    if (age > 10 || age == -1) { }

    if (name.StartsWith("a") == true) { }
    if (name.Length == 1) { }
    if (name == "abc") { }
    if (name != "abc") { }

    if (age == 10 || name == "abc") { }
    else if (age == 20) { }

    if (name == "abc") { }
    else { }
}