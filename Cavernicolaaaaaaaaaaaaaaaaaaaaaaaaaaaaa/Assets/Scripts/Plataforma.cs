using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    private PlatformEffector2D effector;

    public float starWaitTime;

    private float waitedTime;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            waitedTime = starWaitTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            if (waitedTime<=0)
            {
                effector.rotationalOffset = 180f;
                waitedTime = starWaitTime;
            }
            else
            {
                waitedTime -= Time.deltaTime;
            }
        }

        if (Input.GetKey("space"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
