using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    public GameObject efectoSangrePrefab;
    Animator miAnimador;
    private ReproductorSonidos misSonido;
    public bool aturdido = false;
    public bool muerto = false;

    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonido = GetComponent<ReproductorSonidos>();
    }

    // Update is called once per frame
    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe da�o de "
            + puntos + " por " + atacante.name);
        //resto los puntos al HP actual
        hp = hp - puntos;
        miAnimador.SetTrigger("DA�AR");
        if (hp<= 0 && tag == "Player")
        {
            Personaje elPerso = GetComponent<Personaje>();
            elPerso.morirAgua(0,this.gameObject);
            Invoke("morirPersonaje",2.5f);
        }
        else if (hp <= 0 && vidas > 0)
        {
            vidas--;
            muerto = true;
            miAnimador.SetTrigger("MUERTE");
        }
        
        //Creo una instancia de la part de sangre
        GameObject sangre = Instantiate(
            efectoSangrePrefab, transform);

        misSonido.reproducir("DA�AR");
        aturdido = true;
        //Programo que se ejecute el metodo
        //Desaturdir dentro de 1 segundo
        Invoke("desaturdir", 1);
    }

    public void morirAgua(int vidaPerdida, GameObject atacante)
    {
        print(name + "recibe da�o de "
      + atacante.name);

        vidas = vidas - vidaPerdida;
        hp = 0;
        misSonido.reproducir("MORIR");
        miAnimador.SetTrigger("MUERTE");
        muerto = true;
        
    }
    public void morirPersonaje()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void desaturdir()
    {
        aturdido = false;
    }
}
