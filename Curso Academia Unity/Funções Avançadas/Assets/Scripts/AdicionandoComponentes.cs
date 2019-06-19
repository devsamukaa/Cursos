using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdicionandoComponentes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Tecla G
        if(Input.GetKeyDown(KeyCode.G))
        {
            gameObject.AddComponent<Rigidbody2D>();
        }

    }
}
