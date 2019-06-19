using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    private int velocity = 5;
    private float movimento = 0;

    public float force;

    private Rigidbody2D playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetAxis("Horizontal")!=0)
        {   
            movimento = Input.GetAxis("Horizontal");
            playerRigidBody.velocity = new Vector2(movimento * velocity , playerRigidBody.velocity.y);
        }
        

        if(Input.GetKeyDown(KeyCode.Space)){
            playerRigidBody.AddForce(new Vector2(0, force)); 
        }
    }
}
