using PruebaState.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaState
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ProcesoContext(new Preparado());

            context.Validar();
            context.Iniciar();
            context.Finalizar();

            Console.ReadKey();
        }       
    }
}
