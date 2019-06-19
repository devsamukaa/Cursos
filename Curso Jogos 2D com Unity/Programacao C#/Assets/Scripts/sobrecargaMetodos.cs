using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobrecargaMetodos : MonoBehaviour
{
    // Start is called before the first frame update

    calculadora calc;
    void Start()
    {
        int     resultInt;
        float   resultFloat;

        calc = new calculadora();

        resultInt   =       calc.calcula(5,2);
        resultFloat =       calc.calcula(2.0f, 4.0f);

        Debug.Log(resultInt);
        Debug.Log(resultFloat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class calculadora
{

    /*
        Sobrecarga de métodos: Trata-se de criar métodos com mesmo nome, porém que recebem tipos de parâmetros diferentes,
        Geralmente também possuem retornos diferentes, mas não é obrigatório
    */
    public int calcula(int x, int y)
    {
        return x + y;
    }

    public int calcula(float x, float y)
    {   
        return int.Parse(x.ToString()) + int.Parse(y.ToString());
    }
}
