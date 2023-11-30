using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metaaaa : MonoBehaviour
{
    private ReproductorSonidos misSonido;
    private GameObject checkpoint;
    public GameObject reaparecePrefab;
    public GameObject CelebPrefab;
    private Personaje miPersonaje;
    private Animator miAnimador;
    void Start()
    {
        misSonido = GetComponent<ReproductorSonidos>();
        checkpoint = GameObject.FindGameObjectWithTag("Player");
        miPersonaje = GetComponent<Personaje>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        Personaje elPerso = otro.GetComponent<Personaje>();

        if (otro.tag == "Player")
        {
            print("El " + name + " colisiona con " + collision);
            misSonido.reproducir("Vamoooo");
            GameManager.x = transform.position.x;
            GameManager.y = transform.position.y;
            GetComponent<BoxCollider2D>().enabled = false;
            GameObject reaparece = Instantiate(reaparecePrefab);
            reaparece.transform.position = this.transform.position;
            Destroy(reaparece, 3f);
            Invoke("Festejar",5);
        }
    }
}
