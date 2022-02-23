namespace SamplePorject;

public class Lion : Animal
{
    public override void Run()
    {
        base.Run();
        Console.WriteLine( "I ate buser..." );
    }
}
