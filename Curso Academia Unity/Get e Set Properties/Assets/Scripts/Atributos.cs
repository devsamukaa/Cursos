using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributos : MonoBehaviour
{

    [Header("Informações do Jogador")]
    [Tooltip("Controla a Velocidade do Jogador")]
    public float velocidade;

    
    [Range(0,10)]
    public int vidas;

    // [HideInInspector]
    [SerializeField]
    [Multiline(5)]
    private string info;


    [Space(25)]
    [Header("Informações dos Inimigos")]
    public float velocidadeInimigo;
    public int ataque;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
