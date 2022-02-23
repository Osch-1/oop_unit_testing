namespace SamplePorject;

public class Dog : Animal
{
    public override void Run()
    {
        base.Run();
        Console.WriteLine( "Woof woof..." );
    }
}
