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
        static void Main(string[] args)
        {
            AutoCarreras Ferrari = new AutoCarreras();
            Ferrari.modelo = "Ferrari F150";
            Ferrari.peso = 1.3f;
            Ferrari.velocidad = 230;

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren A45S";
            mcLaren.peso = 0.98f;
            mcLaren.velocidad = 280;

            AutoCarreras Koenigsegg = new AutoCarreras();
            Koenigsegg.modelo = "Koenigsegg One:1";
            Koenigsegg.peso = 1.2f;
            Koenigsegg.velocidad = 230;

            PistaCarreras hmnosRodriguez = new PistaCarreras();
            hmnosRodriguez.nombre = "Autódromo Hermanos Rodríguez";
            hmnosRodriguez.longitud = 5.6f;//son km

            //mando a competir a los coches
            hmnosRodriguez.Competir(Ferrari, mcLaren);

            //Esta instrucción espera a que des enter para continuar
            Console.ReadLine();
        }
    }
}
