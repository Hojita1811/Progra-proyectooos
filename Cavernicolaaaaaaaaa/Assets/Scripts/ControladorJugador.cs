using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadCaminar = 3f;
    public float fuerzaSalto = 50f;
    public bool enPiso = false;
    public float saltosMax = 2f;

    private Rigidbody2D miCuerpo;
    //private SpriteRenderer cavernicola;
    private Animator miAnimador;
    private float saltosRest;
    private ReproductorSonidos misSonido;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        // cavernicola = GetComponent<SpriteRenderer>();
        miAnimador = GetComponent<Animator>();
        misSonido = GetComponent<ReproductorSonidos>();
        saltosRest = saltosMax;
    }

    // Update is called once per frame
    void Update()
    {
        //La comprobacion de piso
        //es lo primero que se hace
        //cada frame
        comprobarPiso();

        float velActualVert = miCuerpo.velocity.y;
        //eje horizontal de las flechas
        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)//a la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = false;
            miAnimador.SetBool("Caminando", true);
        }
        else if (movHoriz < 0)//a la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = true;
            miAnimador.SetBool("Caminando", true);
        }

        else//quieto
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("Caminando", false);
        }

        if(enPiso)
        {
            saltosRest = saltosMax;
            miAnimador.SetBool("Piso", true);
        }
        else if (enPiso==false)
        {
            miAnimador.SetBool("Piso", false);
        }

        if (Input.GetButtonDown("Jump") && saltosRest > 0)
        {
            saltosRest--;
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
            miAnimador.SetBool("Piso", false);
            misSonido.reproducir("SALTAR");
        }

        miAnimador.SetFloat("Vel_Vert", velActualVert);
        
    }
    public void comprobarPiso()
    {
        //Lanzo un rayo de deteccion
        //de colisiones hacia abajo
        //desde la posicion del este
        //objeto (cavernicola)
        enPiso = Physics2D.Raycast(
            transform.position,//desde donde
            Vector2.down,//hacia abajo
            0.1f);//distancia
    }
}