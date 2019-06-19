using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotaoJogar()
    {
        Debug.Log("Botão Jogar foi clicado!");
    }

    public void BotaoConquistas()
    {
        Debug.Log("Botão Conquistas foi clicado!");
    }

    public void BotaoLoja()
    {
        Debug.Log("Botão Loja foi clicado!");
    }

    public void BotaoConfig()
    {
        Debug.Log("Botão Config foi clicado!");
    }

    public void BotaoSair()
    {
        Application.Quit();
    }
}
