// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static bool Flag = false;
    public static void Main(string[] args)
    {
        var action = new Func<bool>(GetBoolResult);
        Task.Run(action);
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine("***");
        }
        Console.WriteLine($"Result: {Flag}");
    }

    private static bool GetBoolResult()
    {
        for (int i = 0; i < 100; i++)
        {
            if(Flag)
            {
                Console.WriteLine(Flag);
                Flag = false;
            }

            Console.WriteLine(Flag);
            Flag = true;
        }

        return false;
    }
}
