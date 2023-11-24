using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
   private Animator miAnimador;
    public int puntosCurados = 20;
    public Personaje heroe;
    private ReproductorSonidos misSonido;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonido = GetComponent<ReproductorSonidos>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D curar)
    {
        Curacion pocion = GetComponent<Curacion>();
        print(name + "hizo colision con" + curar.gameObject.name);
        GameObject otro = curar.gameObject;
        if (otro.tag == "Player" && heroe.hp <= 80)
        {
            miAnimador.SetTrigger("Curado");
            heroe.hp = heroe.hp + puntosCurados;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1.5f);
            misSonido.reproducir("Curar");
        }
    }
}