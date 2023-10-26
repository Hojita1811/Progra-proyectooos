using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float VelocidadCaminar = 1.5f;
    public float jumpForce = 12;
    public bool enPiso = false;
    public int saltoDoble = 2;
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    private reproductorsonidos misSonidos;

    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<reproductorsonidos>();
    }

    // Update is called once per frame
    void Update()
    {
        //La comprobaciòn de piso
        //es lo primero que se hace 
        //cada frame
        comprobarPiso();
        float velActualVert = MiCuerpo.velocity.y;
       
        if (saltoDoble <= 0)
        {
            if(enPiso)
            {
                saltoDoble = 2;
            }
        }

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
        if (Input.GetButtonDown("Jump"))
        {
            if (enPiso) 
            {
                {
                    print("Saltooo");
                    MiCuerpo.AddForce(
                        new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
                    saltoDoble = saltoDoble - 1;
                }    
            }
        else if (enPiso == false && saltoDoble > 0){
            MiCuerpo.AddForce(
                 new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
            saltoDoble = saltoDoble - 1;
        }
        MiAnimador.SetFloat("velvert", velActualVert);
            misSonidos.reproducir("SALTAR");
        }
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
