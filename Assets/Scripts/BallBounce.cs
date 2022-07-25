using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 LastVelocity;
    public static bool IsDestroyed = false;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        LastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed=LastVelocity.magnitude;
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);

        if (collision.gameObject.tag == "Tank")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            IsDestroyed = true;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Down")
            Destroy(this.gameObject);
       
    }
}
