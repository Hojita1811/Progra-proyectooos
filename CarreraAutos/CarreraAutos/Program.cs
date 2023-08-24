using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    public class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras Ferrari = new AutoCarreras();
            Ferrari.modelo = "Ferrari F150";
            Ferrari.peso = 1.3f;
            Ferrari.velocidad = 230;
            Ferrari.gasolina = 20;

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren A45S";
            mcLaren.peso = 0.98f;
            mcLaren.velocidad = 280;
            mcLaren.gasolina = 30;

            AutoCarreras Koenigsegg = new AutoCarreras();
            Koenigsegg.modelo = "Koenigsegg One:1";
            Koenigsegg.peso = 1.2f;
            Koenigsegg.velocidad = 230;

            PistaCarreras hmnosRodriguez = new PistaCarreras();
            hmnosRodriguez.nombre = "Autódromo Hermanos Rodríguez";
            hmnosRodriguez.longitud = 5.6f;//son km

            //mando a competir a los coches
            hmnosRodriguez.Competir(Ferrari, mcLaren);

            Ferrari.PonerGas(20);
            Ferrari.Arrancar();
            mcLaren.Arrancar();
            Ferrari.Acelerar(200);
            Ferrari.Frenar();
            mcLaren.PonerGas(30);
            mcLaren.Acelerar(100);
            mcLaren.Frenar();

            //Esta instrucción espera a que des enter para continuar
            Console.ReadLine();
        }
    }
}
