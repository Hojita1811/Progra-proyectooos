using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladordeJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    // Start is called before the first frame update
    void Start()
    {
        //Obtengo el componente rigidbody y lo guardo en la variable
        MiCuerpo = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            print("Se presiono salto");
            MiCuerpo.AddForce(
                new Vector3(0, 7, 0),
                ForceMode2D.Impulse);
        }
    }
}
