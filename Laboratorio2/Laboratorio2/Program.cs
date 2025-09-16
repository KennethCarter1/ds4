
using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        { 
            Client client = new Client();
            client.FirstName = "Kenneth";
            client.LastName = "Carter";
            client.Age = 21;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }

    }

    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;

        }
    }
}