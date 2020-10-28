using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new Abstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
