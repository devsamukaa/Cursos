using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncoesUpdates : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // 60 x 1 segundo
        // 0.01 até 0.06 ms
        // Utilizar funções com pouco processamento
        Debug.Log("Tempo de execução do Update " + Time.deltaTime);

    }

    void FixedUpdate() {

        //O Tempo não varia, tempo é fixo independente do processamento
        //Utilizar para física, Colisão entre objetos, etc.
        Debug.Log("Tempo de execução da FixedUpdate " + Time.deltaTime);    
    }

    void LateUpdate() {

        // Utilizar para a câmera acompanhar o personagem...
        Debug.Log("Tempo de execução do LateUpdate!");
    }
}
