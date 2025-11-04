using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8
{
    class Trabajador: Persona
    {
        public int Sueldo;

      
    public Trabajador(string nombre, int edad, string nif, int sueldo)
            :base(nombre,edad,nif)
        {
            Sueldo = sueldo;
        }
    }
}
