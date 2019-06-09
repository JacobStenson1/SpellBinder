using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    //Rigidbody2D rb;

    public float speed;

    public Rigidbody2D rb;
    public PlayerActions playerActions;
    public GameObject destroyEffect;

    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            Debug.Log("hit something");
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                print("hit enemy");
                //hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            DestroyProjectile();
            //Destroy(gameObject);
        }


        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void DestroyProjectile()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
