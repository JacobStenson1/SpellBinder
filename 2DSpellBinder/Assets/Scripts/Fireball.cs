using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    //Rigidbody2D rb;

    public float speed;

    public Rigidbody2D rb;
    public CircleCollider2D collider;
    public PlayerActions playerActions;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        collider.enabled = true;
        //playerActions = GameObject.Find("Tom").GetComponent<PlayerActions>();
        //playerActions.canShoot = true;
    }
}
