using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTiro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Função para quando sai da cena (fica invisível)
    private void OnBecameInvisible() 
    {
        Destroy(this.gameObject);    
    }
}
