namespace SamplePorject;

public class Animal : IRunner
{
    public virtual void Run()
    {
        Console.WriteLine( "Running as animal" );
    }
}
