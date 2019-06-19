using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{

    private Animator    playerAnimator;
    private Rigidbody2D playerRigidBody2D;
    public Transform    groundCheck, bala;

    public bool         isGrounded;
    public bool         facingRight = true;

    public float        speed;
    public float        direcao;

    //Pulo
    public bool         jump = false;
    public float        jumpForce;
    public int          numberJumps = 0;
    public int          maxJumps = 2;

    //Tiro
    public float        velocidadeTiro;
    public GameObject   tiroPrefab;

    //Tempo do tiro
    public float        delayTiro;
    private bool        tiroDisparado;
    
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")) && playerRigidBody2D.velocity.y == 0;

        playerAnimator.SetBool("isGrounded", isGrounded);

        direcao = Input.GetAxisRaw("Horizontal");

        ExecutaMovimentos();

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(Input.GetButton("Fire1") && !tiroDisparado)
        {
            if(playerRigidBody2D.velocity.x != 0 && isGrounded)
            {
                Atirar();
            }
        }
    }

    void FixedUpdate() 
    {
        MovePlayer(direcao);

        if(jump)
        {
            JumpPlayer();
        }
    }

    void JumpPlayer()
    {

        if(isGrounded)
        {
            numberJumps = 0;
        }

        if(isGrounded || numberJumps < maxJumps)
        {
            playerRigidBody2D.AddForce(new Vector2(0f, jumpForce));
            numberJumps++;
            isGrounded = false;
        }
        jump = false;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        velocidadeTiro *= -1;
        transform.localScale = theScale;
    }

    void ExecutaMovimentos()
    {
        playerAnimator.SetFloat( "velocidadeY", playerRigidBody2D.velocity.y);
        playerAnimator.SetBool( "Jump", !isGrounded);
        playerAnimator.SetBool( "Run", playerRigidBody2D.velocity.x != 0 && isGrounded );

    }

    void MovePlayer(float movimentoH)
    {
        playerRigidBody2D.velocity = new Vector2(movimentoH*speed, playerRigidBody2D.velocity.y);
        if( movimentoH < 0 && facingRight || movimentoH > 0 && !facingRight )
        {
            Flip();
        }
    }

    void Atirar()
    {
        tiroDisparado = true;
        StartCoroutine("tempoTiro");

        GameObject temporarioTiro = Instantiate(tiroPrefab);
        temporarioTiro.transform.position = bala.position;

        if(!facingRight)
        {
            temporarioTiro.GetComponent<SpriteRenderer>().flipX = true;
        }

        temporarioTiro.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeTiro, 0);
    }

    IEnumerator tempoTiro()
    {
        yield return new WaitForSeconds(delayTiro);
        tiroDisparado = false;
    }
}
