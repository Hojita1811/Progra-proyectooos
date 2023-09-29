using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusCam : MonoBehaviour
{
    public Transform Cavernicolaa;
    // Start is called before the first frame update o cuando inicia el nivel xd
    void Start()
    {
         
    }

    // Update is called once per frame o revisa y actua cada cierta cantidad de frames xd
    void Update()
    {
        transform.position = new Vector3(
                Cavernicolaa.position.x,
                Cavernicolaa.position.y, -1
                );
    }
}
