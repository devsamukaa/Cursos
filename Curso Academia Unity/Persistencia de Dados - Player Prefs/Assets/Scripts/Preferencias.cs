using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Preferencias : MonoBehaviour
{

    public Text     _txtPontuacao;
    public Text     _txtVida;
    public Text     _txtNome;
    


    // Start is called before the first frame update
    void Start()
    {
        GravaInformacoes();
        LerInformacoes();
        // ApagaChave();
        // ApagarTodasChaves();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GravaInformacoes()
    {
        PlayerPrefs.SetInt("pontuacao_do_jogador", 850);
        PlayerPrefs.SetInt("vida_do_jogador", 1);
        PlayerPrefs.SetString("nome_do_jogador", "Samuel Rocha");
    }

    void LerInformacoes()
    {
        _txtPontuacao.text = PlayerPrefs.GetInt("pontuacao_do_jogador").ToString();
        _txtVida.text = PlayerPrefs.GetInt("vida_do_jogador").ToString();
        _txtNome.text = PlayerPrefs.GetString("nome_do_jogador");
    }

    void ApagaChave()
    {
        PlayerPrefs.DeleteKey("nome_do_jogador");
    }

    void ApagarTodasChaves()
    {
        PlayerPrefs.DeleteAll();
    }
}
