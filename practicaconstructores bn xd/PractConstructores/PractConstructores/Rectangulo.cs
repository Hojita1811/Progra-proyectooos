using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractConstructores
{
    class Rectangulo
    {
        private float Base = 0.5f;
        private float Altura = 1.5f;

        public Rectangulo()
        {
            //Sin parametros
        }
        public Rectangulo(float valorBase, float valorAltura)
        {
            Base = valorBase;
            Altura = valorAltura;
        }

        public void Describir()
        {
            Console.WriteLine("La altura del rectangulo es " + Altura + " y su base es " + Base);
        }

        public float calcPerim()
        {
            float perim = Base + Base + Altura + Altura;
            return perim;
        }
    }
}
