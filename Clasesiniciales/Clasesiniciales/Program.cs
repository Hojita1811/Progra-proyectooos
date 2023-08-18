using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasesiniciales
{
    class Program
    {
        //Este es el metodo main
        //Sirve como punto de entrada
        //para el programa (inicia desde aqui)
        static void Main(string[] args)
        {
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vynyl";
            mochilaAna.NumeroDeBolsas = 3;
            mochilaAna.NumeroDeLlaveros = 0;
            mochilaAna.Precio = 500.00;
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 30;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.Material = "Piel";
            mochilaBeto.NumeroDeBolsas = 3;
            mochilaBeto.NumeroDeLlaveros = 3;
            mochilaBeto.Precio = 179.50;
            mochilaBeto.color = new Color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;

            Mochila mochilaAlberto = new Mochila();
            mochilaAlberto.Disenio = "Perry";
            mochilaAlberto.Material = "Plástico";
            mochilaAlberto.NumeroDeBolsas = 4;
            mochilaAlberto.NumeroDeLlaveros = 2;
            mochilaAlberto.Precio = 250.00;
            mochilaAlberto.color = new Color();
            mochilaAlberto.color.Rojo = 200;
            mochilaAlberto.color.Verde = 20;
            mochilaAlberto.color.Azul = 30;

            Smartphone smartphoneFran = new Smartphone();
            smartphoneFran.Modelo = "Xiaomi Redmi Note 11";
        smartphoneFran.Tech = "GSM";
        smartphoneFran.Anio = 2022;
        smartphoneFran.Dispo = "Disponible";
        smartphoneFran.Dim1 = 159.9f;
        smartphoneFran.Dim2 = 73.9f;
        smartphoneFran.Dim3 = 8.1f;
        smartphoneFran.Peso = 179;
        smartphoneFran.SIM = "Dual SIM (Nano-SIM, dual stand-by) IP53, dust and splash resistant";
        public string Tipo;
        public float Tamaño;
        public int Resolancho;
        public int Resolalto;
        public string Protect;
        public string OS;
        public string Chip;
        public string CPU;
        public string GPU;
        public string Card;
        public int Memoria;
        public int CamWide;
        public string Feat;
        public int VidP;
        public int fps;
        public int SCam;
        public string SVid;
        public string LoudS;
        public bool Jack
        public string WLAN;
        public string BT;
        public string Pos;
        public bool NFC;
        public bool Infrared;
        public string Radio;
        public string USB;
        public string Sensors;
        public string Bateria;
        public string Carga;
        public string Col;
        public string Mod;
        public string SAR;
        public float Precio;
    }
    }
}
