using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDelegate : MonoBehaviour
{

    delegate void ExecuteMeuDelegate();
    ExecuteMeuDelegate executeMeuDelegate;


    // Start is called before the first frame update
    void Start()
    {
        executeMeuDelegate += MostraInformacao;
        executeMeuDelegate += GanhaForca;

        if(executeMeuDelegate != null){
            executeMeuDelegate();
            // executeMeuDelegate -= MostraInformacao;
            // executeMeuDelegate -= GanhaForca;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MostraInformacao(){
        Debug.Log("Olá");
    }

    void GanhaForca(){
        Debug.Log("Você ganhou mais força!");
    }
}
