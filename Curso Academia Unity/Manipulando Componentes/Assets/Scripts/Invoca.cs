using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // sintaxe
        Invoke("DestroiObjeto", 3f);

        InvokeRepeating("DestroiObjeto", 3f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            CancelInvoke("DestroiObjeto");
        }
    }

    void DestroiObjeto(){
        Debug.Log("Objeto destruido");
    }
}
