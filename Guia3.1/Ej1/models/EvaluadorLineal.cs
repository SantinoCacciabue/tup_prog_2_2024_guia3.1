using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class EvaluadorLineal : Evaluador
    {
        public int VidaUtil {  get; set; }
        public EvaluadorLineal(Moto vehiculo, int añoACalcular, int vidaUtil):base(vehiculo, añoACalcular)
        {
            VidaUtil = vidaUtil;
        }
        public override double CalcularDepreciacion()
        {
            double valor;
            int añosDeUso = AñoACalcular - vehiculo.Modelo;
            valor = vehiculo.ValorFabricacion-(vehiculo.ValorFabricacion* añosDeUso/VidaUtil);
            return valor;
        }
        public override string VerDescripcion()
        {
            return $"Vehiculo: {vehiculo.VerDescripcion()} Depreciación lineal: {CalcularDepreciacion()}";
        }
    }
}
