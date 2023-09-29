using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractConstructores
{
    class Triangulo
    {
        private float Base = 0.5f;
        private float Altura = 1.5f;

        public Triangulo()
        {
            //Sin parametros
        }
        public Triangulo(float valorBase, float valorAltura)
        {
            Base = valorBase;
            Altura = valorAltura;
        }

        public void Describir()
        {
            Console.WriteLine("La altura del triangulo es " + Altura + " y su base es " + Base);
        }

        public float calcArea()
        {
            float ba = Base*Altura;
            float area = ba / 2;
            return area;
        }
    }
}
