using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    //CONSTRUCTORES -- PILDORAS INFORMÁTICAS VIDEO 30
    //  https://www.youtube.com/watch?v=FobGQKXVpH0&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=30
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();//Creamos un ejemplo de la clase coche
            //damos un estado inicial a nuestro coche

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());


            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.getInfoCoche());

        }
    }
    class Coche
    {
        
        public Coche() //Este es el constructor que no es ni void ni devuelve nada es un metoddo especial - El constructor debe tener el mismo nombre de la clase
        {
            ruedas = 4;
            largo= 2300.5;
            ancho = 0.800;
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
        }

        public String getInfoCoche()
        {
            
            return "Información del coche: \nRuedas: "+ ruedas + " \nLargo: " + largo + "\nAncho: " + ancho + "\n";
        }
        
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;






    }
}
