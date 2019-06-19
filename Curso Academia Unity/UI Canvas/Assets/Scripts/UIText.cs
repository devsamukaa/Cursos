using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{

    public Text nivel, distancia;
    int somaDistancia = 0;

    // Start is called before the first frame update
    void Start()
    {
        nivel.text = "Nível: 2";
        distancia.text = "0 m";
    }

    // Update is called once per frame
    void Update()
    {
        somaDistancia++;
        distancia.text = somaDistancia.ToString() + " m";

        

    }
}
