using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaState.Estados
{
    class Preparado : EstadoProceso
    {

        public override void Interrumpir()
        {
            this._context.Transitar(new Interrumpido());
        }

        public override void Validar()
        {
            this._context.Transitar(new Validado());
        }

        public override void Exportar()
        {
            throw new NotImplementedException();
        }

        public override void Finalizar()
        {
            throw new NotImplementedException();
        }

        public override void Previsualizar()
        {
            throw new NotImplementedException();
        }

        public override void Iniciar()
        {
            throw new NotImplementedException();
        }
    }
}
