using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio88
{
    class ClaseConcreta1 : ClassAbstracts
    {
        protected override string tomarValor()
        {
            return "ClaseConcreta1";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClassConcreta1";
        }
    }

}
