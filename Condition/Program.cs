using Conditions;

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




BasicSample.Sample1(12);
BasicSample.Sample2("test");
BasicSample.Sample3(22, "test123");
