using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lacoForeach : MonoBehaviour
{

    string[] inimigos;

    // Start is called before the first frame update
    void Start()
    {
        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "mark";
        
        foreach(string nome in inimigos)
        {
            Debug.Log(nome);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
