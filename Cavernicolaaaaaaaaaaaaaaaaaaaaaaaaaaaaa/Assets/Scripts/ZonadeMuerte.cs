using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonadeMuerte : MonoBehaviour
{
    public int vidaPerdida = 1;
    public GameObject efectoSumergir;
    private ReproductorSonidos misSonido;
    void Start()
    {
        misSonido = GetComponent<ReproductorSonidos>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        print(name + "Toco: "
            + trigger.gameObject.name);

        GameObject otro = trigger.gameObject;
        if (otro.tag == "Player")
        {
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.morirAgua(vidaPerdida, this.gameObject);
            GameObject sumergir = Instantiate(
            efectoSumergir, elPerso.transform);

            misSonido.reproducir("SUMERGIR");
        }
    }
}
