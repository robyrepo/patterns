using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
    class Client
    {
        public void Main()
        {
            ClientCode(new ShipCreator());
            ClientCode(new TrukCreator());
        }

        
        public void ClientCode(Creator creator)
        {
            Console.WriteLine($"Deliver by {creator.Create()}");
        }
    }

    abstract class Creator
    {
        public abstract ITransport FactoryMethod();

        public string Create()
        {
            var transport = FactoryMethod();
            var result = $"deliver by {transport.Deliver()}";
            return result;
        }
    }

    class TrukCreator : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new Truk();
        }
    }

    class ShipCreator : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }

    public interface ITransport
    {
        string Deliver();
    }

    class Truk : ITransport
    {
        public  string Deliver()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class Ship : ITransport
    {
        public string Deliver()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
