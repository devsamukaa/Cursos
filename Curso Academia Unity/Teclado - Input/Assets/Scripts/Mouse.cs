using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    public Texture2D mousePonteiro;

    // Start is called before the first frame update
    void Start()
    {
        //A função que realiza mudança
        Cursor.SetCursor(mousePonteiro, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
        // 0 esquerda
        // 1 direita
        // 2 meio

        if(Input.GetMouseButton(0))
        {
            Debug.Log("Botão esquerdo do mouse pressionado.");
        }

        if(Input.GetMouseButton(1))
        {
            Debug.Log("Botão direito do mouse pressionado.");
        }

        if(Input.GetMouseButton(2))
        {
            Debug.Log("Botão do meio do mouse pressionado.");
        }

    }
}
