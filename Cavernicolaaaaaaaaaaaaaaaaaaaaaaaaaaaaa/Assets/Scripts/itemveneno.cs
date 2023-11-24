using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemveneno : MonoBehaviour
{
    public int puntosDanio = 5;
    public float duracionefecto = 4;
    private Animator miAnimador;
    private Personaje victima;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //animar el item para su desaparicion
       //miAnimador.SetTrigger("DESAPARECER");
            //desactivar el collider
            GetComponent<Collider2D>().enabled = false;
            //Obtener el personaje del objeto que choco
            victima = collision.GetComponent<Personaje>();

            InvokeRepeating("envenenar", 1, 1);
            Destroy(this.gameObject, duracionefecto);
        }
    }

    private void envenenar()
    {
        victima.hacerDanio(puntosDanio, this.gameObject, Personaje.TiposDanio.Magico);

    }
}
