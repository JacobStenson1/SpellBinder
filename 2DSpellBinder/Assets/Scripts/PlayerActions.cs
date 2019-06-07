using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    public GameObject fireballPrefab;
    public GameObject firePoint;
    ParticleSystem firePointPS;

    public Animator animator;
    public PlayerMovement playerMovement;
    public Rigidbody2D rb;

    public bool canShoot = true;

    private void Start()
    {
        animator = GetComponent<Animator>();
        firePointPS = firePoint.GetComponent<ParticleSystem>();


    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            CastSpell();
        }
        if (Input.GetKeyDown("q"))
        {
            Interact();
        }

    }

    void CastSpell()
    {
        if (canShoot)
        {
            print("Shooting");

            // If standing still
            if (rb.velocity.x < 0.1 && rb.velocity.x > -0.1)
            {
                print("okay to");
                firePointPS.Play();
                animator.Play("Shoot");
            }
        }
    }

    void Interact()
    {

    }

    void Shoot()
    {
        Instantiate(fireballPrefab, firePoint.transform.position, firePoint.transform.rotation);
    }

    void AfterShoot()
    {
        playerMovement.canMove = true;
    }
}
