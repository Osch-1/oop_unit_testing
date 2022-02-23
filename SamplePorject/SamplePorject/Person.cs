namespace SamplePorject;

public class Person : IRunner, ISwimmer
{
    public string Name { get; set; }

    public virtual void Run()
    {
        Console.WriteLine( "Running as person" );
    }

    public void Swim()
    {
        Console.WriteLine( "Person swims" );
    }
}