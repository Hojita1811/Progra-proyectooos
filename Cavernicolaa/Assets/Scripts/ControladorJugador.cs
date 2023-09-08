using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float VelocidadCaminar = 1.5f;
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
    }
}
