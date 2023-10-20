using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 80;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    public GameObject efectoSangrePreFab;
    public GameObject efectoAwa;
    private Animator MiAnimador;
    private reproductorsonidos misSonidos;

    void Start()
    {
        
    }

    public void hacerDanio(int puntos, GameObject atacante) 
    {
        print(name + "recibe daño de "
            + puntos + " por " + atacante.name);

        //resto los puntos al HP actual
        hp = hp - puntos;

        MiAnimador.SetTrigger("DAÑAR");
        GameObject sangre = Instantiate(
            efectoSangrePreFab, transform);
        misSonidos.reproducir("DAÑAR");
    }

    public void muerteInstant(GameObject agua)
    {
        hp = 0;
        //o vidas = vidas -1;
        vidas--;
        GameObject awa = Instantiate(
            efectoAwa, this.transform);
        misSonidos.reproducir("MORIR");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
