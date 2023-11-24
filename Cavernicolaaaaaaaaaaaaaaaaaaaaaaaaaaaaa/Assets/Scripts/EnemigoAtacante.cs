using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtacante : MonoBehaviour
{
    public float distanciaAgro = 4;
    private GameObject heroe;
    private Rigidbody2D yoCuerpo;
    public float velJaiba = 2f;
    private Animator miAnimador;
    public int puntosDanio = 35;
    public float distanciaAtaque = 3;
    public GameObject efectoGolpe;
    private Personaje miPersonaje;
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
            GameObject golpe = Instantiate(efectoGolpe, elPerso.transform);
        }
    }
    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
        yoCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        if (distancia < distanciaAgro && distancia > distanciaAtaque && !miPersonaje.aturdido && !miPersonaje.muerto)
        { //el heroe esta dentro de la zona de agro
            if (posHeroe.x > posYo.x)
            { //el heroe esta a la derecha
                transform.rotation = Quaternion.Euler(0, 180, 0);
                yoCuerpo.velocity = new Vector3(velJaiba, 0, 0);
                miAnimador.SetBool("CaminJaiba", true);
                miAnimador.SetBool("JaibaAtaca", false);
            }
            else
            { //el heroe esta a la izquierda
                transform.rotation = Quaternion.Euler(0, 0, 0);
                yoCuerpo.velocity = new Vector3(-velJaiba, 0, 0);
                miAnimador.SetBool("CaminJaiba", true);
                miAnimador.SetBool("JaibaAtaca", false);
            }


        }
        else if(distancia < distanciaAgro && distancia < distanciaAtaque && !miPersonaje.aturdido && !miPersonaje.muerto)
        {
            if (posHeroe.x > posYo.x)
            { //el heroe esta a la derecha
                transform.rotation = Quaternion.Euler(0, 180, 0);
                yoCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("JaibaAtaca", true);
                miAnimador.SetBool("CaminJaiba", false);
            }
            else
            { //el heroe esta a la izquierda
                transform.rotation = Quaternion.Euler(0, 0, 0);
                yoCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("JaibaAtaca", true);
                miAnimador.SetBool("CaminJaiba", false);
            }
        }
        else
        {
            //el heroe esta fuera de la zona de agro
            yoCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("JaibaAtaca", false);
            miAnimador.SetBool("CaminJaiba", false);
        }

    }
}

