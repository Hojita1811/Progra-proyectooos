using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Música
{
    class Program
    {
        static void Main(string[] args)
        {
            Artista artistaChopin = new Artista();
            artistaChopin.nombre = "Frederic Chopin";
            artistaChopin.gen = "Clasica";
            artistaChopin.anio = 1810;
            artistaChopin.edad = 39;
            artistaChopin.nacion = "Polonia";

            Artista artistaLiszt = new Artista();
            artistaLiszt.nombre = "Franz Liszt";
            artistaLiszt.gen = "Clasica";
            artistaLiszt.anio = 1811;
            artistaLiszt.edad = 74;
            artistaLiszt.nacion = "Hungria";

            Artista artistaIchiko = new Artista();
            artistaIchiko.nombre = "Ichiko Aoba";
            artistaIchiko.gen = "Folk";
            artistaIchiko.anio = 1990;
            artistaIchiko.edad = 33;
            artistaIchiko.nacion = "Japon";

            cancion cancionChopin = new cancion();
            cancionChopin.nom = "Op. 48 No. 1";
            cancionChopin.gen = "Clasica";
            cancionChopin.duracion = 5.52f;
            cancionChopin.artista = "Frederic Chopin interpretada por Arthur Rubinstein";

            cancion cancionLiszt = new cancion();
            cancionLiszt.nom = "Liebestraum";
            cancionLiszt.gen = "Clasica";
            cancionLiszt.duracion = 4.45f;
            cancionLiszt.artista = "Franz Liszt interpretada por Arthur Rubinstein";

            cancion cancionIchiko = new cancion();
            cancionIchiko.nom = "Ikinokori Bokura";
            cancionIchiko.gen = "Folk";
            cancionIchiko.duracion = 6.46f;
            cancionIchiko.artista = "Ichiko Aoba";

            album albumChopin = new album();
            albumChopin.nombre = "Chopin piano Concertos nos. 1 and 2";
            albumChopin.anio = 1999;
            albumChopin.gen = "Clasica";
            albumChopin.artista = "Frederic Chopin interpretados por Krystian Zimerman";

            album albumLiszt = new album();
            albumLiszt.nombre = "Kissin plays Liszt";
            albumLiszt.anio = 1987;
            albumLiszt.gen = "Clasica";
            albumLiszt.artista = "Franz Liszt interpretados por Evgeny Kissin";

            album albumIchiko = new album();
            albumIchiko.nombre = "0";
            albumIchiko.anio = 2013;
            albumIchiko.gen = "Folk";
            albumIchiko.artista = "Ichiko Aoba";
        }
    }
}
