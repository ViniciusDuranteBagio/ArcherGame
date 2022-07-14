using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAgro : MonoBehaviour
{
    [SerializeField]
     public Transform player;
    [SerializeField]
    public float agroRange;
    [SerializeField]
    public Animator animator;
    [SerializeField]
    public float moveSpeed;

    public float distToPlayer;
    private Rigidbody2D rb2d;

    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {

        distToPlayer = Vector2.Distance(transform.position, player.position);
        
        if(distToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasePlayer();
        }
    }

    private void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
          //  animator.SetBool("walking", true);
          // animator.SetBool("searchingPlayer", true);

            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(1, 1);

        }
        else 
        {
           // animator.SetBool("walking", true);
           // animator.SetBool("searchingPlayer", true);
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);

        }
    }

    private void StopChasePlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
}
