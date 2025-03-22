using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    class Motocicleta : Vehiculo
    {
        private string encendido = "patada";
        private string tipoDeFreno = "De Disco";
        private bool frenoDemano = false;

        public Motocicleta(int anio, string model, string elColor) : base(anio, model, elColor)
        {
        }
        public void vertipoDeFreno()
        {
            Console.WriteLine("Tipo de freno: {0}", tipoDeFreno);
        }
        public string verencendido()
        {
            return encendido;
        }
        public void ponerfrenoDemano()
        {
            frenoDemano = !frenoDemano;
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto * 3);

        }
        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            if (!frenoDemano)
            {
                Console.WriteLine("Frenando con el freno de disco");
            }
            else
            {
                Console.WriteLine("Frenando con el freno de mano");
            }

        }

    }
}
