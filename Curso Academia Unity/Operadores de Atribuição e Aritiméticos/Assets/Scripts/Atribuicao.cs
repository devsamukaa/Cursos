using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atribuicao : MonoBehaviour
{

    // int velocidade = 100;
    // int distancia = 10;
    // int tempo = 10;

    int resultado = 0;
    int velocidade = 100, distancia = 100, tempo = 10;

    // += -= *= /= %=

    // Start is called before the first frame update
    void Start()
    {
        // distancia = distancia + tempo;
        // distancia += tempo;

        // print(distancia);

        resultado = distancia % tempo;
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
