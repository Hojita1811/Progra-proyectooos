using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]
public class reproductorsonidos : MonoBehaviour
{
    public EfectoSonoro[] efectos;
    private AudioSource miSonido;
    // Start is called before the first frame update
    void Start()
    {
        miSonido = GetComponent<AudioSource>();
    }
    public void reproducir(string accion)
    {
        for (int i = 0; i < efectos.Length; i++)
        {
            EfectoSonoro efecto = efectos[i];
            if(efecto.accion == accion)
            {
                //asigna el archivo al audiosource
                miSonido.clip =
                    efecto.archivoSonido;
                //Reproduce el sonido
                miSonido.Play();
                break;
            }
        }
    }
    [Serializable]
    public class EfectoSonoro
    {
        public string accion;
        public AudioClip archivoSonido;
    }
}
