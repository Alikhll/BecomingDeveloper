using Classes;

// create an instance of "User"
// var u = new User();  (you could replace it with "var")
User u = new User();

// we can call methods and properties through an instance we created eralier
// you are not allowed to call "Print" method like this "User.Print()", always required to have an instance
u.Name = "abc"; // update the property value (because its public)
u.Age = 12; // update the property value (because its public)
u.Print(); // call non static method of the class (because its public)

//this is static method and you don't need an instance therefore you can directly call it from its class
User.StaticPrint();

public class User
{
    // a public property that can be accessible
    public string Name;
    public int Age;

    // a public method that can be accessible
    // only non static methods have access to class properties and so on!
    public void Print()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }

    public static void StaticPrint()
    {
        //here is static method and executaion is different 
        //you don't have access to method "Print", properties like "Name", and "Age" here
        Console.WriteLine("I am static method!");
    }
}


// --------- Sample ----------


//BasicSample.Sample1();