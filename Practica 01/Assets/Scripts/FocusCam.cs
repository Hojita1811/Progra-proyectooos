using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCam : MonoBehaviour
{
    public Transform phos;
    // Start is called before the first frame update o cuando inicia el nivel xd
    void Start()
    {
         
    }

    // Update is called once per frame o revisa y actua cada cierta cantidad de frames xd
    void Update()
    {
        transform.position = new Vector3(
                phos.position.x,
                phos.position.y, -1
                );
    }
}
