using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    class AutoDeCombustion: Vehiculo
    {
        private int nivelDeAceite = 30;
        private string espejos = "2";
        private int nivelLiquidoDefrenos = 70;

        public AutoDeCombustion(int anio, string model, string elColor):  base(anio, model, elColor)
        {
        }
        public void cargarAceite()
        {
            nivelDeAceite++;
        
        }
        public int verNivelDeAceite()
        {
            return nivelDeAceite;
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            nivelDeAceite--;

        }
        public void verEspejos()
        { 
            Console.WriteLine("numeros de espejos: {0}", espejos);

        
        }

        public void verLiquidoDeFrenos()
        {
            Console.WriteLine("nivel de liquido de frenos: {0}", nivelLiquidoDefrenos);

        }

    }
}
