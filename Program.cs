using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    //CONSTRUCTORES -- PILDORAS INFORMÁTICAS VIDEO 30 --
    //  https://www.youtube.com/watch?v=FobGQKXVpH0&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=30 //VT30 Constructores 
    //  https://www.youtube.com/watch?v=7HGwVYsdAxI&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=31 //VT31 GETTER Y SETTER
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
            coche3.setExtras(true, "cuero");

            Console.WriteLine(coche3.getExtras());

        }
    }
    class Coche
    {

        public Coche() //Este es el constructor que no es ni void ni devuelve nada es un metoddo especial - El constructor debe tener el mismo nombre de la clase
                       //Todas las clases tienen un constructor aunque no se vea por defecto estará invocando al constructor por defecto, en este caso public Coche(){ruedas=...}...
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            climatizador = false;
            tapiceria = "Tela";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
            climatizador = false;
        }

        public String getInfoCoche()
        {

            return "Información del coche: \nRuedas: " + ruedas + " \nLargo: " + largo + "\nAncho: " + ancho + "\n";
        }

       
        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;//Si le dejo climatizador = climatizador: se observa una ambigüedad y genera un error lógico ya que no se visualiza el valor correcto
            this.tapiceria = tapiceria;//this. hace referencia a la variable o campo de clase... es decir al objeto en el que nos encontremos, en la propia clase
        }

        public String getExtras()
        {
            return "Extras del coche:\n" + "Tapicería: " + tapiceria + "\nClimatizador: " + climatizador;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;//por defecto el valor es false
        private String tapiceria;//por defecto el valor es ""  -- Vacío

    }
}
