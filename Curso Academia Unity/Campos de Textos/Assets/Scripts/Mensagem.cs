using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour
{

    public Text txt;
    public InputField inputNome;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostraMensagem()
    {
        txt.text = "Seja Bem vindo(a): " + inputNome.text;
    }
}
