using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_constructores
{
    class Dragon
    {
        private string color = "gris";
        private string tipo = "hielo";
        private int cantAlas = 4;
        private int peso = 25000;

        public Dragon()
        {
        }

        public Dragon(string valorTipo, string valorColor)
        {//este es un constructor
            //establezco el estado
            //inicial del objeto
            tipo = valorTipo;
            color = valorColor;
        }


        public void presentarse()
        {
            Console.WriteLine(
            " yo soy un dragón de "
            + tipo + "color "
            + color +
            "y voy a comerlos a todos");
        }

        public float calcVelocidad()
        {
            return cantAlas / peso;
        }
    }
    public class Rectangulo
    {
        private float Base = 0.5f;
        private float Altura = 1.5f;


        public Rectangulo()
        { 
            
        }
        public Rectangulo(float valorBase, float valorAltura)
        {
            
        }
    }
}
