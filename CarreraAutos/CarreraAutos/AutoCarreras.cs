using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class AutoCarreras
    {
        public string modelo;
        public float peso;
        public int velocidad;
        public float gasolina;

        public void Acelerar(int ac) 
        {
            velocidad = velocidad + ac;
            gasolina = gasolina - velocidad / 10f;
            Console.WriteLine(
                "El " + modelo + " acelera a "
                + velocidad + "km/h");
            if (gasolina <= 0)
            {
                Console.WriteLine("El auto se detuvo");
            }
            else {
                Console.WriteLine("El auto avanzó");
            }
        }
        public void Frenar()
        {
            velocidad = 0;
            Console.WriteLine(
                "Y llega a " + velocidad + "km/h al final.");
        }
        public void PonerGas(float cantidad)
        {
            gasolina = gasolina + cantidad;
            Console.WriteLine(
                modelo + " tiene "
                + gasolina + "1 de gas");
        }
        public void Arrancar()
        {
            if (gasolina > 0)
            {
                gasolina = gasolina - 0.01f;
                Console.WriteLine(
                    "Arrancando " + modelo + ", le quedan "
                    + gasolina + "1 de gas.");
            }
            else
            {
                Console.WriteLine(
                "No se puede arrancar "
                + modelo + "sin gasolina.");
            }

        }
    }
}
