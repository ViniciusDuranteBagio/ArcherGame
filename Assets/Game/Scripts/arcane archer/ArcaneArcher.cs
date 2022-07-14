using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneArcher : MonoBehaviour
{
    //----------------Components--------------
    public Rigidbody2D rb;
    public Animator animator;
    //--------------------Prefabs----------------------

    //----------------Heros Variabel Movements--------------
    public int moveSpeed;
    private float direction;
    [SerializeField]
    private bool isOnGround;
    [SerializeField]
    private int extraJump = 1;

    private bool isDead = false;





    public Transform detectGround;
    public LayerMask IsGround;

    public bool facingRight = true;
    

    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }


    void Update()
    {
        if (!isDead) {
            if (!animator.GetBool("shoot")) {
                Movement();
            }


            Jump();
            Damage();
        }
    }

     private void Movement()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);

        if (direction > 0 && !facingRight ) 
        {
            facingRight = !facingRight;
            transform.Rotate(0f,180f,0f);
        }
        if (direction < 0 && facingRight)
        {
            facingRight = !facingRight;
            transform.Rotate(0f, 180f, 0f);
        }


        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }


    }

    private void Jump()
    {
        isOnGround = Physics2D.OverlapCircle(detectGround.position, 0.2f, IsGround);
        if(Input.GetButtonDown("Jump") && isOnGround) {
            rb.velocity = Vector2.up * 8;
            animator.SetBool("isJumping", true);

        }

        if (Input.GetButtonDown("Jump") && !isOnGround && extraJump > 0) {
            rb.velocity = Vector2.up * 8;
            extraJump--;
        }
        if (isOnGround && rb.velocity.y == 0) {
            extraJump = 1;
            animator.SetBool("isJumping", false);

        }


    }

    private void Damage()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            isDead = true;
            animator.SetTrigger("isDead");
        }
    }



       

      
    

}
