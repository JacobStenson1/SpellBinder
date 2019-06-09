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

    public float timeBetweenShots;
    public float startTimeBetweenShots;

    public bool isCasting;

    private void Start()
    {
        animator = GetComponent<Animator>();
        firePointPS = firePoint.GetComponent<ParticleSystem>();


    }

    void Update()
    {
        if (timeBetweenShots <= 0)
        {
            isCasting = false;
            if (Input.GetKeyDown("e"))
            {
                CastSpell();
                timeBetweenShots = startTimeBetweenShots;
            }
        }else
        {
            timeBetweenShots -= Time.deltaTime;
        }
        
        if (Input.GetKeyDown("q"))
        {
            Interact();
        }

    }

    void CastSpell()
    {
        print("Shooting");
        isCasting = true;
        firePointPS.Play();
        animator.Play("Shoot");
    }

    void Interact()
    {
        // Not implemented yet
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
