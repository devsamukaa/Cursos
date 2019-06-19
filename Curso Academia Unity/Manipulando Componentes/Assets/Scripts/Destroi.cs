using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DestroiObjeto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroiObjeto(){
        //Destruir objeto

        Destroy(gameObject,5f);

        //Destroy (objeto, 10f)
    }
}
