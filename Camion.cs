using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    class Camion : Vehiculo
    {
        private int cargaActual;
        private string tipo = "Transporte Comercial";
        private int asientos = 4;
        private int numerollantas = 6;

        public Camion(int anio, string model, string elColor) : base(anio, model, elColor)
        {
           
        }
        public int NumeroLlantas
        {
            get { return numerollantas; }
            set { if (value > 0) numerollantas = value; }
        }
        public int Asientos
        {
            get { return asientos; }
            set
            {
                if (value > 0)
                {
                    asientos = value;
                }
            }
        }

        public string Tipo
        {
            get { return tipo; }
            set
            {
                if (value != null)
                {
                    tipo = value;
                }
            }
        }

        public void tipovehiculo()
        {
            Console.WriteLine("Tipo de vehiculo: {0}", tipo);

        }
        public void verAsientos()
        {
            Console.WriteLine("Asientos: {0}", asientos);
        }
        public void verNumeroLlantas()
        {
            Console.WriteLine("Numero de llantas: {0}", numerollantas);
        }
        public void cargar(int cuanto)
        {
            cargaActual = cargaActual + cuanto;
            Console.WriteLine("Cargando {0} toneladas", cuanto);
        }
        public void descargar()
        {
            cargaActual = 0;
            Console.WriteLine("El camion ha sido descargado.");

        }
        public int verCapacidadCarga()
        {
            return 10;
        
        }

    }
}
