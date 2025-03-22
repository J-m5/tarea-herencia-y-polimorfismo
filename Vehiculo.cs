using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }

        private int velocidad = 0;
        private bool encendido = true;



        public Vehiculo(int anio, string model, string elColor)
        {
            this.Color = elColor;
            this.Modelo = model;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            if (encendido)
            {
                velocidad += cuanto;
                Console.WriteLine("vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehiculo esta apagado. No puedes acelerar");

            }


        }

        public virtual void Frenar(int cuanto)
        {
            if (encendido)
            {
                velocidad -= cuanto;
                Console.WriteLine("Has frenado, vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehiculo esta apagado.No puedes frenar"); 
            }
        }

        public void encender()
        {
            if (encendido)
            {
                encendido = true;
                Console.WriteLine("El vehiculo esta encendido");

            }
            else
            {
                Console.WriteLine("El vehiculo ya esta encendido");
            }

        }

        public void apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("El vehiculo esta apagado");
            }
            else
            {
                Console.WriteLine("El vehiculo ya esta apagado");
            }
        }

    }
}
