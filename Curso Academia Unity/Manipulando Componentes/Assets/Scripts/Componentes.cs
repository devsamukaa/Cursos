using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componentes : MonoBehaviour
{

    private SpriteRenderer verSprite, flipSprite, mudaCor;
    private Color cor32 = new Color32(64,128,192,255);

    // Start is called before the first frame update
    void Start()
    {
        verSprite = GetComponent<SpriteRenderer>();
        flipSprite = GetComponent<SpriteRenderer>();
        mudaCor = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E)){
            verSprite.enabled = !verSprite.enabled;
        }

        if(Input.GetKeyDown(KeyCode.F)){
            flipSprite.flipX = !flipSprite.flipX;
        }

        if(Input.GetKeyDown(KeyCode.C)){
            mudaCor.color = cor32;
        }
    }
}
