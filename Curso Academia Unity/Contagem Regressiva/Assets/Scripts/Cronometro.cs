using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    
    public float _tempoInicial = 0;
    public Text _cronometro;
    public Text _textoBotao;

    bool _cronometroAtivo = false;
    // Start is called before the first frame update
    void Start()
    {
        _cronometro.text = _tempoInicial.ToString("F2") + "m";


    }

    // Update is called once per frame
    void Update()
    {
        if(_cronometroAtivo)
        {
            _tempoInicial += Time.deltaTime;
            _cronometro.text = _tempoInicial.ToString("F2") + "m";
        }
    }

    public void botaoTempo()
    {
        _cronometroAtivo = !_cronometroAtivo;
        _textoBotao.text = _cronometroAtivo ? "Pausar" : "Iniciar";
    }
}
