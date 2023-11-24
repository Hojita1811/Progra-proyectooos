using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cofre : MonoBehaviour

{
    public float distAgro = 1;
    private Animator miAnimador;
    private GameObject heroe;
    private Rigidbody2D miCuerpoo;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        heroe = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;//pos heroe
        Vector3 posYo = this.transform.position;//pos honguito

        float distancia = (posYo - posHeroe).magnitude;//vector entre los dos
        if (Input.GetButtonDown("Jump") && distancia < distAgro)
        {
            miAnimador.SetTrigger("abrir");
        }

    }
}
