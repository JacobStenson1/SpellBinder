using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{

    public GameObject fireball;
    public Transform firePoint;

    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            print("Testing");
            animator.Play("Shoot");
        }
    }

    void Shoot()
    {
        Instantiate(fireball, firePoint.position, firePoint.rotation);
    }
}
