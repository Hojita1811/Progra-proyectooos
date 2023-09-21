using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float VelocidadCaminar = 1.5f;
    public float jumpForce = 12;
    public bool enPiso = false;
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;

    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //La comprobaciòn de piso
        //es lo primero que se hace 
        //cada frame
        comprobarPiso();
        float velActualVert = MiCuerpo.velocity.y;
       
        float movHoriz = Input.GetAxis("Horizontal");
        if (movHoriz > 0)//a la derecha
        {                                       //x, y y z
            transform.rotation = Quaternion.Euler(0, 0, 0);
            MiCuerpo.velocity = new Vector3(
                VelocidadCaminar, velActualVert, 0);
            MiAnimador.SetBool("caminando", true);
        }
        else if (movHoriz < 0)//a la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            MiCuerpo.velocity = new Vector3(
                -VelocidadCaminar, velActualVert, 0);
            MiAnimador.SetBool("caminando", true);
        }
        else//quieto
        {
            MiCuerpo.velocity = new Vector3(0, velActualVert, 0);
            MiAnimador.SetBool("caminando", false);
        }
        if (enPiso) {
            if (Input.GetButtonDown("Jump")) //GetKey pa tecladoo
            {
                print("Saltooo");
                MiCuerpo.AddForce(
                    new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
                
            }    
        }
        else if (enPiso == false){
               
        }
        MiAnimador.SetFloat("velvert", velActualVert);
    }

    void comprobarPiso()
    {
        //Lanzo un rayo de deteccion
        //de colisiones hacia abajo
        //desde la posicion de este
        //objeto (cavernicola)
        enPiso = Physics2D.Raycast(
            transform.position,//desde donde
            Vector2.down,//hacia abajo
            0.1f//distancia
            );
    }
}
