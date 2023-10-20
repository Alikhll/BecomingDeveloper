namespace Iterations;


public partial class TroubleShootingSample
{
    public static void Trouble1()
    {
       var arr = new int[2]; // you have declared an array that capacity of two

       arr[0] = 123;
       arr[1] = 444;

       arr[10] = 10; // you don't have index 10 and therefore your app will break here
       // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
       
    }
}
