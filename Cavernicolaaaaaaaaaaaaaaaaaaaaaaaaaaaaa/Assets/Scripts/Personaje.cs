using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Personaje : MonoBehaviour
{
    public enum TiposDanio
    {
        Fisico,
        Magico,
        Fuego,
        Aire,
        Contundente,
        Cortante
    }

    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public static int vidas = 3;
    public GameObject efectoSangrePrefab;
    public bool aturdido = false;
    public bool muerto = false;
    public int vidaPerdida = 1;
    Animator miAnimador;
    private ReproductorSonidos misSonido;
    public GameObject efectoDanioMagico;
    
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonido = GetComponent<ReproductorSonidos>();
    }


    public void hacerDanio(int puntos, 
        GameObject atacante, 
        TiposDanio tipo = TiposDanio.Fisico)
        //si no se manda el tipo, por defecto asigna Fisico
    {
        print(name + "recibe daño de "
            + puntos + " por " + atacante.name + "de tipo" + tipo);

        //resto los puntos al HP actual
        hp = hp - puntos;
    
        misSonido.reproducir("DAÑAR");

        //Creo una instancia de la part de sangre
        
        if (tipo == TiposDanio.Fisico)
        {
            aturdido = true;
            miAnimador.SetTrigger("DAÑAR");
            GameObject sangre = Instantiate(
            efectoSangrePrefab, transform);
            Invoke("desaturdir", 1);
        }
        else if(tipo == TiposDanio.Magico)
        {
            Instantiate(efectoDanioMagico, transform);
        }


        if (hp <= 0)
        {
            muerto = true;
            miAnimador.SetTrigger("Muerto");
        }
        if (hp <= 0 && vidas <= 0)
        {
            Personaje elPerso = GetComponent<Personaje>();
            elPerso.morirAgua(vidaPerdida, this.gameObject);
        }
        else if (hp <= 0 && vidas > 0)
        {
            vidas--;
            muerto = true;
        }
        aturdido = true;
        //Programo que se ejecute el metodo
        //destruir dentro 1 seg
        Invoke("desaturdir", 1);
    }
    private void desaturdir()
    {
        aturdido = false;

    }

    public void morirAgua(int vidaPerdida, GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = vidas - vidaPerdida;
        hp = 0;
        misSonido.reproducir("MORIR");
        miAnimador.SetTrigger("Muerto");

        muerto = true;
    }
    public void Festejar()
    {
        print(name + "Toca la meta");
        misSonido.reproducir("CELEBRA");
        miAnimador.SetTrigger("Celebracion");
    }
}
