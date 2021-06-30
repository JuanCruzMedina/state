﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaState.Estados
{
    class Iniciado : EstadoProceso
    {
        public override void Finalizar()
        {
            this._context.Transitar(new Finalizado());
        }

        public override void Interrumpir()
        {
            this._context.Transitar(new Interrumpido());
        }

        public override void Iniciar()
        {
            throw new NotImplementedException();
        }

        public override void Exportar()
        {
            throw new NotImplementedException();
        }

        public override void Previsualizar()
        {
            throw new NotImplementedException();
        }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
