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
            smartphoneFran.Tipo = "AMOLED, 90Hz, 700 nits, 1000 nits (peak)";
            smartphoneFran.Tamanio = 99.8f;
            smartphoneFran.Resolancho = 1080;
            smartphoneFran.Resolalto = 2400;
            smartphoneFran.Protect = "Corning Gorilla Glass 3";
            smartphoneFran.OS = "Android 11, upgradable to Android 13, MIUI 14";
            smartphoneFran.Chip = "Qualcomm SM6225 Snapdragon 680 4G";
            smartphoneFran.CPU = "Octa-core";
            smartphoneFran.GPU = "Adreno 610";
            smartphoneFran.Card = "microSDXC";
            smartphoneFran.Memoria = 64;
            smartphoneFran.CamWide = 50;
            smartphoneFran.Feat = "LED flash, HDR, panorama";
            smartphoneFran.VidP = 1080;
            smartphoneFran.fps = 30;
            smartphoneFran.SCam = 13;
            smartphoneFran.SVid = 1080;
            smartphoneFran.LoudS = "Yes, with stereo speakers";
            smartphoneFran.Jack = true;
            smartphoneFran.WLAN = "Wi-Fi 802.11 a/b/g/n//ac, dual-band, Wi-Fi Direct";
            smartphoneFran.BT = "5.0, A2DP, LE";
            smartphoneFran.Pos = "GPS, GLONASS, BDS, GALILEO";
            smartphoneFran.NFC = true;
            smartphoneFran.Infrared = true;
            smartphoneFran.Radio = "FM radio";
            smartphoneFran.USB = "USB Type-C 2.0, OTG";
            smartphoneFran.Sensors = "Fingerprint (side-mounted), accelerometer, gyro, compass, Virtual proximity sensing";
            smartphoneFran.Bateria = "Li-Po 5000 mAh, non-removable";
            smartphoneFran.Carga = "33W wired, PD3.0, QC3, 100% in 60 min (advertised)";
            smartphoneFran.Col = "Graphite Gray, Twilight Blue, Star Blue";
            smartphoneFran.Mod = "2201117TG, 2201117TI, 2201117TY, 2201117TL";
            smartphoneFran.SAR = "0.97 W/kg (head) 0.93 W/kg (body)";
            smartphoneFran.Precio = 159.99f;
    }
    }
}
