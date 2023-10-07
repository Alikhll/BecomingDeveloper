//static method to resue functionality called "Print" returns void
static void Print()
{
    Console.WriteLine("Print something");
}

//call a method here
Print();




// ------------------------------------
// ------------ sample 2 --------------
// ------------------------------------





//static method called PrintName, get a string parameter and returns void means nothing!
static void PrintName(string name)
{
    Console.WriteLine("Name: " + name);
}

string n = "myName";

//call a method and pass a variable (method's return is void)
PrintName(n);





// ------------------------------------
// ------ more samples -------
// ------------------------------------




//return type is "int" and gets two integer parameters as well
static int Sum(int num1, int num2)
{
    return num1 + num2;
}

int i1 = 2;
int i2 = 3;

// call a method Sum (pass parameters) and retunr the result into another variable called "sum1"
int sum1 = Sum(i1, i2);

Console.WriteLine(sum1);

int sum2 = Sum(10, 20);

Console.WriteLine(sum2);





// --------------------------------------------




//here we try to do some nice tricks
//call the fundtion "GetFullName" and pass all parameters and directly retrun the result ino "Conosle.WriteLine"
//the result will be printed
Console.WriteLine(GetFullName("myFirstName", "myLastName"));

static string GetFullName(string fName, string lName)
{
    return fName + " - " + lName;
}