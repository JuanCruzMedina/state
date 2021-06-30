using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaState.Estados
{
    public class ProcesoContext
    {
        private EstadoProceso estado;

        public ProcesoContext(EstadoProceso estado)
        {
            this.Transitar(estado);
        }
        public void Transitar(EstadoProceso state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this.estado = state;
            this.estado.SetEstado(this);
        }
        public void Iniciar()
        {
            this.estado.Iniciar();
        }
        public void Finalizar()
        {
            this.estado.Finalizar();
        }
        public void Interrumpir()
        {
            this.estado.Interrumpir();
        }
        public void Previsualizar()
        {
            this.estado.Previsualizar();
        }
        public void Validar()
        {
            this.estado.Validar();
        }
        public void Exportar()
        {
            this.estado.Exportar();
        }
    }
}
