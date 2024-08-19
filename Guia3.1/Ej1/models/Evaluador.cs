using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    abstract class Evaluador
    {
        public Moto vehiculo;
        public Moto Vehiculo
        {
            get
            {
                return vehiculo;
            }
        }
        protected int añoACalcular;
        public int AñoACalcular
        {
            get
            {
                return añoACalcular;
            }
        }
        public Evaluador(Moto vehiculo, int añoACalcular)
        {
            this.vehiculo = vehiculo;
            this.añoACalcular = añoACalcular;
        }
        public abstract double CalcularDepreciacion();
        public virtual string VerDescripcion()
        {
            return $"Vehiculo: {vehiculo.VerDescripcion()}";
        }
    }
}
