using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{

    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Image barraHPHeroe;
    public Text ScoreEtiqueta;
    public Text Score;

    // Update is called once per frame
    void Update()
    {
        EtiquetaHPHeroe.text = Heroe.hp + "/" + Heroe.hpMax;
        float porcentajeHP = Heroe.hp / (float)Heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHP;
        ScoreEtiqueta.text = "Score: ";
        Score.text = "000000";
    }
}
