using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio88
{
    abstract class ClassAbstracts
    {
       
     abstract protected string tomarValor();
     abstract public string prefixValor(string prefix);
        // Metodo comin
        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
}
