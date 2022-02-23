namespace SamplePorject;

public class Runner : Person
{
    public override void Run()
    {
        base.Run();
        Console.WriteLine( "I'm fast" );
    }
}
