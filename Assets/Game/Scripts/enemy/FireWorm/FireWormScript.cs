using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireWormScript : MonoBehaviour
{
    [SerializeField]
    private GameObject fireBall;

    [SerializeField]
    public Transform player;


    public float distToPlayer;
    public bool mustPatrol;

    [SerializeField]
    public float rangeFireWorm;
    [SerializeField]
    private float speedFireBall = 1.0f;

    public bool attackMode = false;

    // Esse codigo está todo comentado pois ele estava em desenvolvimento junto com o projeto
    // porem esse projeto foi pausado por mim pois estou sem tempo e tenho que terminar o tcc
    // assim que terminar o tcc vou dar continuidade ao projeto

    void Start()
    {

        mustPatrol = true;
      

    }
    // olhar o script enemyAgro para saber onde vai a logica de caso achar o player atacar ele -> talvez usando lá podemos fazer mais generico a parte do agro 

    void Update()
    {
         if (mustPatrol)
         {
            Patrol();//criar o metodo
         }

        //  distToPlayer = Vector2.Distance(transform.position, player.position);

        //  if (distToPlayer <= range)
        //  {
        //   Shoot();
        // }

    }

    private void FixedUpdate()
    {
        //  if (mustPatrol)
        //  {
        //      mustTurn = !Physics2D.OverlapCircle() se precisar virar mas acho que isso ja foi resolvido
        //  }
    }
    void Patrol()
    {
        // if (mustTurn || bodyCollider.IsTouchingLayers(gorundLayer))
        // {
                Flip();
        // }
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        
    }
}
