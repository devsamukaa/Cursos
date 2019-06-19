using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doWhile : MonoBehaviour
{
    // Start is called before the first frame update
    int x = 0;
    void Start()
    {

        do
        {
            Debug.Log("Oi pessoal");
            x++;
        }while(x <= 10);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
