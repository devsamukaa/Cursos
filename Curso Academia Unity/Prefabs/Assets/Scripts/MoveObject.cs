using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Variáveis de velocidade
    [Header("Variáveis de velocidade")]
    public float minimumXSpeed;
    public float maximumXSpeed;
    public float minimumYSpeed;
    public float maximumYSpeed;

    // Variáveis do GamePlay
    [Header("Variáveis do GamePlay")]
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minimumXSpeed, maximumXSpeed),
            Random.Range(minimumYSpeed, maximumYSpeed)
        );

        //Esperar e destruir o Objeto
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
