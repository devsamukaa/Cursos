using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakAndContinue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        /* ESTRUTURA - BREAK */
        for(int i=0; i<=10; i++){
            print(i);
            if(i==5)
            {
                /*  
                    Break interrompe e sai do bloco de laço. 
                    Sempre deve ser acompanhado de uma condicional. 
                    Do contrário, executará somente uma vez o laço. 
                */
                break;
            }
        }


        /* ESTRUTURA - CONTINUE */
        for(int i=0; i<=10; i++){
            Debug.Log("teste1");
            if(i==5)
            {   
                /*  
                    Continue interrompe e passa para a nova instrução do laço. 
                    Sempre deve ser acompanhado de uma condicional. 
                    Do contrário, executará somente o que estiver anterior a ele, dentro do laço.
                */
                continue;
            }
            Debug.Log("teste2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
