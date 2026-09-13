char[] charCollection = ['a', 'b'];
Console.WriteLine("Hello, World!");

public class TrainingClass
{
    public async Task ProcessAsync(char[] chars)
    {
        Memory<char> span = chars.AsMemory(1, 2);

        await SomeOperationAsync();

        Console.WriteLine(span);
    }
    
    public async Task SomeOperationAsync()
    {
        Span<char> span = stackalloc char[10];
        span[0] = 'j';
        span[1] = 'y';
    }
}

