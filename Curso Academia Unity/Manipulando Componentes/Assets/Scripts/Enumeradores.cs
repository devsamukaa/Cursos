using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeradores : MonoBehaviour
{

    public enum Heroi { Parado, Correndo, Morrendo, Pulando };

    public Heroi acao;

    // Start is called before the first frame update
    void Start()
    {
        if(acao == Heroi.Correndo)
        {
            Debug.Log("Personagem correndo");
        }else if(acao == Heroi.Morrendo)
        {
            Debug.Log("Personagem morrendo");
        }else if(acao == Heroi.Parado)
        {
            Debug.Log("Personagem parado");
        }else if(acao == Heroi.Pulando)
        {
            Debug.Log("Personagem pulando");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
