using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 80;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;

    void Start()
    {
        
    }

    public void hacerDanio(int puntos, GameObject atacante) 
    {
        print(name + "recibe daño de "
            + puntos + " por " + atacante.name);

        //resto los puntos al HP actual
        hp = hp - puntos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
