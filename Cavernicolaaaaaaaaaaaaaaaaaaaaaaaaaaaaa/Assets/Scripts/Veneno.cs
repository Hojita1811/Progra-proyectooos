using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public Personaje heroe;
    public int danioHecho = 5;
    public float danioRep = 2f;
    private Animator miAnimador;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D veneno)
    {
        Veneno pocionV = GetComponent<Veneno>();
        print(name + "hizo colision con" + veneno.gameObject.name);
        GameObject otro = veneno.gameObject;
        if (otro.tag == "Player")
        {
            InvokeRepeating("DanioConstante", 0f, danioRep);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 3f);
            miAnimador.SetTrigger("Envenenado");
        }
    }

    void DanioConstante()
    {
        if (heroe != null)
        {
            heroe.hacerDanio(danioHecho, this.gameObject);
        }
    }
}