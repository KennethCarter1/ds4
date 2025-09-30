using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8
{
    class Persona
    {
 

            public string Nombre;

            public int Edad;

            public string NIF;

            void Cumpleaños() 
            {
                Edad++;
            }


            public Persona(string nombre, int edad, string nif)
            {
                Nombre = nombre;
                Edad = edad;
                NIF = nif;
            }
    }
}
