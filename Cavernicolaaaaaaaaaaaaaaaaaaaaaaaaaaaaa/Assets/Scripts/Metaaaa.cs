using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Metaaaa : MonoBehaviour
{
    private ReproductorSonidos misSonido;
    public GameObject CelebPrefab;
    public GameObject CelebPrefab2;
    private Animator miAnimador;
    void Start()
    {
        misSonido = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.tag == "Player")
        {
            print("El " + name + " colisiona con " + collision);
            misSonido.reproducir("Celebrar");
            GameObject celebrar = Instantiate(CelebPrefab);
            GameObject celeee = Instantiate(CelebPrefab2);
            celebrar.transform.position = this.transform.position;
            Personaje elPerso = otro.GetComponent<Personaje>();
            GetComponent<BoxCollider2D>().enabled = false;
            elPerso.Festejar(this.gameObject);
        }
    }
}
