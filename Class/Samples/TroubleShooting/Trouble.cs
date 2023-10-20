namespace Classes;


public class MyClass
{
    private void F1() // private method
    {
        //we can call F2 without instantiating because it's already inside the class
        F2(); // it's same as this.F2()
        this.F2();

        //inside non-static method we can call static methods and fields and so on in case we have access to it
        F3();
        F4();
    } 
    public void F2() { } // public method
    private static void F3() { } //private static method!
    public static void F4() { } //public static method!



    public static void TroubleMethod()
    {
        F3(); // we can call F3 because it's static and being private doesn't matter because this method has the same level as well
        F4(); // we can call F4 method 

        // inside static methods we are not able to call non-static methods directly!
        //F1();  
        //F2();
    }
}

public partial class TroubleShootingSample
{
    public static void Trouble1()
    {
        //F3 is private so we don't have access to it
        //error CS0122: 'MyClass.F3()' is inaccessible due to its protection level

        //MyClass.F3();

        MyClass.F4(); //It's fine :)
    }

    public static void Trouble2()
    {
        //F2 is public but it's non static therefore we need to first instintiate it
        //error CS0120: An object reference is required for the non-static field, method, or property 'MyClass.F2()

        //MyClass.F2();




        var myclass = new MyClass();
        myclass.F2(); //It's fine

        //myclass.F1(); it doesn't work because F1 is private therefore you don't have access to it
    }
}