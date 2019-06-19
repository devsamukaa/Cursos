using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "objetos")
        {
            Debug.Log(collision.gameObject.name);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Debug.Log("Deixou de Colidir com um objeto");
    }

    private void OnCollisionStay2D(Collision2D collision) {
        // Debug.Log("Sempre colidindo com um objeto");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "objetos")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        // Debug.Log("Saiu da colisão com o celular");
    }

    private void OnTriggerStay2D(Collider2D collision) {
        // Debug.Log("Colidindo com o celular");
    }
}