﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ControleDePontos : MonoBehaviour
{

    public int pontuacao;

    void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            pontuacao++;
            Debug.Log("Pontos da Fase: " + pontuacao.ToString());
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
           SceneManager.LoadScene("Fase02");
        }
    }
}
