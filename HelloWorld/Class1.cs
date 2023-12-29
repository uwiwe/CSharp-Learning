class Program
{
    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.model = "Lamborghini";
        Ford.color = "purple";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Ferrari";
        Opel.color = "black";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
        Ford.fullThrottle();  // Call the method
    }
}