using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    public GameObject fireballPrefab;
    public GameObject firePoint;
    ParticleSystem firePointPS;

    public Animator animator;

    bool canShoot = true;

    private void Start()
    {
        animator = GetComponent<Animator>();
        firePointPS = firePoint.GetComponent<ParticleSystem>();

    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (canShoot)
            {
                canShoot = false;

                print("Shooting");
                firePointPS.Play();
                animator.Play("Shoot");
            }
        }
    }

    void Shoot()
    {
        Instantiate(fireballPrefab, firePoint.transform.position, firePoint.transform.rotation);
    }

    void AfterShot()
    {
        canShoot = true;
    }
}
