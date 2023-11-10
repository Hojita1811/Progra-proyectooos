using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigomediano : MonoBehaviour
{
    public float velCaminar = 6.5f;
    public float distanciaAgro = 5;
    public float distanciaAgrocortaa = 3;
    private GameObject heroe;
    private Animator animadorr;
    private Rigidbody2D miCuerpoo;
    public int puntosDanio = 10;
    private Personaje miEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
        animadorr = GetComponent<Animator>();
        miCuerpoo = GetComponent<Rigidbody2D>();
        miEnemigo = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;//pos heroe
        Vector3 posYo = this.transform.position;//pos honguito

        float distancia = (posYo - posHeroe).magnitude;//vector entre los dos
        float velActualVert = miCuerpoo.velocity.y;
        if (distancia < distanciaAgro && distancia > distanciaAgrocortaa && !miEnemigo.aturdido && !miEnemigo.muerto)
        {   //el heroe esta dentro de la zona de agro

            if (posHeroe.x > posYo.x)
            {//el heroe está a la derecha del villano
                transform.rotation = Quaternion.Euler(0, 0, 0);
                animadorr.SetBool("Caminando", true);
                miCuerpoo.velocity = new Vector3(velCaminar, velActualVert, 0);
                animadorr.SetBool("atacar", false);
            }
            else if (!miEnemigo.aturdido && !miEnemigo.muerto)
            {//el heroe está a la izquierda
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animadorr.SetBool("Caminando", true);
                miCuerpoo.velocity = new Vector3(-velCaminar, velActualVert, 0);
                animadorr.SetBool("atacar", false);
            }
        }
        else if (distancia < distanciaAgro && distancia < distanciaAgrocortaa)
        {
            if (posHeroe.x > posYo.x && !miEnemigo.aturdido && !miEnemigo.muerto)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                animadorr.SetBool("Caminando", true);
                miCuerpoo.velocity = new Vector3(velCaminar, velActualVert, 0);
                animadorr.SetBool("atacar", false);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                animadorr.SetBool("Caminando", false);
                miCuerpoo.velocity = new Vector3(0, 0, 0);
                animadorr.SetBool("atacar", true);
            }
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            animadorr.SetBool("Caminando", false);
            miCuerpoo.velocity = new Vector3(0, 0, 0);
            animadorr.SetBool("atacar", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colisión con "
            + collision.gameObject.name);

        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accedo al componente de tipo Personaje
            //del objeto con el que choqué
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando al metodo hacer daño
            elPerso.hacerDanio(puntosDanio, this.gameObject);
        }
    }
}
