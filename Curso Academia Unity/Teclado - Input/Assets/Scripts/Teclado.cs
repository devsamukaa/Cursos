using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Comando keycode
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tecla de espaço pressionada!");
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Tecla de espaço foi liberada!");
        }

    }
}
