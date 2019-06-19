using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecao : MonoBehaviour
{

    public Toggle selecaoNome;
    public InputField txtNome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Status()
    {
        if(selecaoNome.isOn == true)
        {
            txtNome.readOnly = false;
        }else
        {
            txtNome.readOnly = true;
        }
    }
}
