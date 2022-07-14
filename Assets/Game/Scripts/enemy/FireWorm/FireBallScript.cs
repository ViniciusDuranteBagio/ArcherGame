using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField]
    private float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
       
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
