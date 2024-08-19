using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class EvaluadorAnual : Evaluador
    {
        public double TasaDepreciacion {  get; set; }
        public EvaluadorAnual(Moto moto, int añoACalcular, double tasaDepreciacion) : base(moto, añoACalcular)
        {
            TasaDepreciacion = tasaDepreciacion;

        }
        public override double CalcularDepreciacion()
        {
            double valor;
            valor = vehiculo.ValorFabricacion * Math.Pow(1 - TasaDepreciacion, añoACalcular - vehiculo.Modelo);
            return valor;
        }
        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()} Depreciacion anual: {CalcularDepreciacion()}" ;
        }
    }
}
