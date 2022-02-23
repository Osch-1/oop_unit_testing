using SamplePorject;

//Runners block
Person person = new Person();

List<IRunner> runners = new List<IRunner>()
{
    person,
    new Runner(),
    new Buser(),
    new Animal(),
    new Dog(),
    new Lion()
};

foreach ( IRunner runner in runners )
{
    runner.Run();
    Console.WriteLine();
}

//Swimmers block
Person swimmer = new Person();
swimmer.Swim();
