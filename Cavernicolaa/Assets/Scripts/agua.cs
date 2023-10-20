using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agua : MonoBehaviour
{
    public GameObject efectoAwa;
    private reproductorsonidos misSonidos;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + " hizo colision con "
            + collision.gameObject.name);
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accedo al componente de tipo Personaje
            //del objeto con el que choqué
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el método hacer daño
            elPerso.muerteInstant(this.gameObject);
            GameObject sangre = Instantiate(
            efectoAwa, transform);
            misSonidos.reproducir("SPLASH");
        }
    }
}
