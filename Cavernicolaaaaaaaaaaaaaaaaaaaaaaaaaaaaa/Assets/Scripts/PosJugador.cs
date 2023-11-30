using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PosJugador : MonoBehaviour
{
    // Start is called before the first frame update
    private Personaje miPersonaje;
    
    void Start()
    {
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if (miPersonaje.muerto)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
