public class Program
{
    static void Main(string[] args)
    {
        PrintState(false);
        PrintState(true);
        PrintState(null);
    }

    //Example 1
    public static void PrintState(bool? state)
    {
        var message = state switch
        {
            true => "State is true",
            false => "State is false",
            _ => "State is indeterminate",
        };

        Console.WriteLine(message);
    }

    // Example 2
    // Compiler show warning, we used true, false and null in main method, 
    // but in PrintState function not include the false & default conditions.

    // public static void PrintState(bool? state)
    // {
    //     var message = state switch
    //     {
    //         true => "State is true"
    //     };

    //     Console.WriteLine(message);
    // }

    // Example 3
    // public static void PrintState(bool? state)
    // {
    //     Console.WriteLine(state switch
    //     {
    //         true => "State is true",
    //         false => "State is false",
    //         _ => "State is indeterminate",        
    //     });
    // }
}
