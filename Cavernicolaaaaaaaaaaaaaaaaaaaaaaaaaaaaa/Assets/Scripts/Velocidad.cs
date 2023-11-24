using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidad : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;
    public ControladorJugador persoPlayer;
    private Collider2D miCollider;
    public int veloAum = 3;


    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D aumentar)
    {
        GameObject otro = aumentar.gameObject;
        if (otro.CompareTag("Player"))
        {
            persoPlayer = otro.GetComponent<ControladorJugador>();
            Velocidad pocion = GetComponent<Velocidad>();
            print(name + "hizo colision con" + aumentar.gameObject.name);
            if (otro.tag == "Player")
            {
                miAnimador.SetTrigger("Veloz");
                GetComponent<Collider2D>().enabled = false;
                Destroy(gameObject, 3);
                persoPlayer.velocidadCaminar = persoPlayer.velocidadCaminar * veloAum;
                Invoke("velocidadAum", 2f);
                GetComponent<Collider2D>().enabled = false;
            }
        }
    }


    public void velocidadAum()
    {
        Debug.Log("Velocidad orginal");
        if (persoPlayer != null)
        {
            persoPlayer.velocidadCaminar = persoPlayer.velocidadCaminar / veloAum;
            Debug.Log("Velocidad caminar = " + persoPlayer.velocidadCaminar);
        }
    }


}
