using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebra : MonoBehaviour
{
    
    private DistanceJoint2D bola;

    void Start()
    {
        bola = GetComponent<DistanceJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            bola.breakForce = 0;
        }
    }
}
