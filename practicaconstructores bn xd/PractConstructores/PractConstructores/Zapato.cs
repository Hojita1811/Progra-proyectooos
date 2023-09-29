using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractConstructores
{
    class Zapato
    {
        private string Color = "Cafe";
        private int Talla = 27;

        public Zapato()
        {
            //Sin parametros
        }
        public Zapato(string valorColor, int valorTalla)
        {
            Color = valorColor;
            Talla = valorTalla;
        }

        public void Describir()
        {
            Console.WriteLine("Es un zapato de talla " + Talla + " color " + Color);
        }
    }
}
