using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroiMove : MonoBehaviour
{

    public bool face = true;
    public Transform heroiTransform;
    public float velocity = 2.5f;
    public float velocityRun = 10.0f;
    public float force = 6.5f;
    public Rigidbody2D heroiRigidBody;
    public bool liberaPulo = false;
    public Animator heroiAnim;
    public bool vivo = true;

    void Start()
    {
        heroiTransform = GetComponent<Transform>();
        heroiRigidBody = GetComponent<Rigidbody2D>();
        heroiAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(vivo)
        {
            // Flip...
            if(Input.GetKey(KeyCode.RightArrow)&& !face) {
                Flip();
            } else if(Input.GetKey(KeyCode.LeftArrow)&& face) {
                Flip();
            }

            // Run...
            
            if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Q)) {
                transform.Translate(new Vector2(velocityRun * Time.deltaTime, 0));
                heroiAnim.SetBool("Idle", false);
                heroiAnim.SetBool("Andar", false);
                heroiAnim.SetBool("Correr", true);
            } else if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Q)) {
                transform.Translate(new Vector2(-velocityRun * Time.deltaTime, 0));
                heroiAnim.SetBool("Idle", false);
                heroiAnim.SetBool("Andar", false);
                heroiAnim.SetBool("Correr", true);
            }

            // Andar...

            else if(Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.Q)) {
                transform.Translate(new Vector2(velocity * Time.deltaTime, 0));
                heroiAnim.SetBool("Idle", false);
                heroiAnim.SetBool("Andar", true);
                heroiAnim.SetBool("Correr", false);
            } else if(Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Q)) {
                transform.Translate(new Vector2(-velocity * Time.deltaTime, 0));
                heroiAnim.SetBool("Idle", false);
                heroiAnim.SetBool("Andar", true);
                heroiAnim.SetBool("Correr", false);

            // Idle...
            
            } else if(!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) {
                heroiAnim.SetBool("Idle", true);
                heroiAnim.SetBool("Andar", false);
                heroiAnim.SetBool("Correr", false);
            }

            // Jump...

            if (Input.GetKeyDown(KeyCode.Space) && liberaPulo && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {
                heroiRigidBody.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
                heroiAnim.SetBool("PuloLateral", true);
                heroiAnim.SetBool("Correr", false);
                heroiAnim.SetBool("Andar", false);
            } else if (Input.GetKeyDown(KeyCode.Space) && liberaPulo)
            {
                heroiRigidBody.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
                heroiAnim.SetBool("PuloLateral", false);
                heroiAnim.SetBool("Correr", false);
                heroiAnim.SetBool("Andar", false);
                heroiAnim.SetBool("Idle", false);
                heroiAnim.SetBool("PuloIdle", true);
            }
        }
    }

    void Flip()
    {
        face = !face;
        Vector3 scale = heroiTransform.localScale;
        scale.x *= -1;
        heroiTransform.localScale = scale;
    }

    void OnCollisionEnter2D(Collision2D collision2D) {
        if(collision2D.gameObject.CompareTag("Chao"))
        {
            liberaPulo = true;
            heroiAnim.SetBool("PuloLateral",false);
            heroiAnim.SetBool("PuloIdle",false);
            heroiAnim.SetBool("Idle",true);
        }
    }

    void OnCollisionExit2D(Collision2D collision2D) {
        if(collision2D.gameObject.CompareTag("Chao"))
        {
            liberaPulo = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision2D) {
        if(collision2D.gameObject.CompareTag("Bomba"))
        {
            vivo = false;
            heroiAnim.SetBool("Andar",false);
            heroiAnim.SetBool("Correr",false);
            heroiAnim.SetBool("Idle",false);
            heroiAnim.SetBool("PuloLateral",false);
            heroiAnim.SetBool("Morte",true);
        }    
    }
}
