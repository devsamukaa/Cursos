using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisAndBase : MonoBehaviour
{
    // Start is called before the first frame update
    
    pai p;
    filho f;

    void Start()
    {
        p = new pai();
        f = new filho();

        Debug.Log(f.pegaIdade().ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class pai
{
    public int idade;
    // public pai(int idade)
    // {   
        /*  "This" referencia o próprio objeto. */
    //     this.idade = idade;
    // }
}

class filho : pai
{

    public int idadeFilho;
    public int pegaIdade()
    {   
        /*
            A palavra reservada "base" serve para pegar os valores de uma classe "origem" dentro
            de uma classe derivada.
        */
        return idadeFilho = base.idade - 10;
    }
}