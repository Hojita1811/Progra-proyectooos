using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon dragon1 = new Dragon();
            dragon1.presentarse();
            float velocidad = dragon1.calcVelocidadVuelo();
            Console.WriteLine("Velocidad: " + velocidad);

            Dragon dragon2 = new Dragon("eléctrico", "amarillo");
            dragon2.presentarse();
            Console.WriteLine(
                "Velocidad: " + dragon2.calcVelocidadVuelo());

            Dragon dragon3 = new Dragon("roca", "blanco");
            dragon3.presentarse();

            Triangulo triangulo1 = new Triangulo();
            triangulo1.Describir();
            Console.WriteLine(
                "Su área es: " + triangulo1.calcArea());

            Rectangulo rectangulo1 = new Rectangulo();
            rectangulo1.Describir();
            Console.WriteLine(
                "Su perimetro es: " + rectangulo1.calcPerim());

            Zapato zapato1 = new Zapato();
            zapato1.Describir();

            Console.ReadLine();
        }
    }
}
