using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcaoAwake : MonoBehaviour
{

    void Awake() {
        // A função Awake é chamada antes da Start e é chamada mesmo se o script estiver desabilitado
        Debug.Log("A função awake foi executada!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("A função start foi executada!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
