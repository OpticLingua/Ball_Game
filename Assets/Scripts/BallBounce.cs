using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallBounce : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 LastVelocity;
    public static bool IsDestroyed = false;
    public GameObject bullet;
    private GameObject tank;
    private Image tank_health;
    private BossEnemy enemyShake;
   
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        tank = GameObject.FindWithTag("Tank_Health_bar");
        tank_health=tank.GetComponent<Image>();
        enemyShake= ScriptableObject.FindObjectOfType<BossEnemy>();
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
            
            tank_health.fillAmount -= 0.3f;
            if(enemyShake.coroutineAllowed)
            enemyShake.StartShaking();
            if (tank_health.fillAmount <= 0)
            {
                Destroy(collision.gameObject);
                
                IsDestroyed = true;
            }
            Destroy(this.gameObject);

        }

       
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Down")
            Destroy(this.gameObject);

        if (collision.gameObject.tag == "PowerUPS")
        {
            Destroy(collision.gameObject);
            PowerUPS();
            PowerUPS();
        }
    }

    public void PowerUPS()
    {
        GameObject firedBullet1 = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        firedBullet1.GetComponent<Rigidbody2D>().velocity = gameObject.transform.right * 10f;
    }
}
