﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    delegate void ExecuteMeuDelegate (int numero);
    ExecuteMeuDelegate executeMeuDelegate;

    // Start is called before the first frame update
    void Start()
    {
        executeMeuDelegate = ImprimirNumero;
        executeMeuDelegate(10);

        executeMeuDelegate = MultiplicaNumero;
        executeMeuDelegate(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ImprimirNumero(int numero){
        Debug.Log("O numero impresso é: " + numero);
    }

    void MultiplicaNumero(int numero){
        Debug.Log("O numéro multiplicado é: " + numero * 2);
    }
}
