
Print();

string n = "myName";

PrintName(n);

int i1 = 2;
int i2 = 3;

int sum1 = Sum(i1, i2);

Console.WriteLine(sum1);

int sum2 = Sum(10, 20);

Console.WriteLine(sum2);

Console.WriteLine(GetFullName("myFirstName", "myLastName"));

static void Print()
{
    Console.WriteLine("Print something");
}

static void PrintName(string name)
{
    Console.WriteLine("Name: " + name);
}

static int Sum(int num1, int num2)
{
    return num1 + num2;
}

static string GetFullName(string fName, string lName)
{
    return fName + " - " + lName;
}