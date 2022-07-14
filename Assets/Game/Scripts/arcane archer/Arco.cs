using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arco : MonoBehaviour
{

    public Animator animator;
    public GameObject arrowPrefab;
    [SerializeField]
    private float atackSpeed = 0.15f;
    [SerializeField]
    private float _canFire = 0.0f;


    public Transform arco;



    private void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
    }

    private void Shoot()
    {
        animator.SetTrigger("shoot");
        if (Time.time > _canFire)
        {
            Instantiate(arrowPrefab, arco.position, arco.rotation);
            _canFire = Time.time + atackSpeed;
        }



    }
}
