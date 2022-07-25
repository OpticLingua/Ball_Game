using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour 
{

	float moveSpeed = 3f;
	Rigidbody2D rb;
	private GameObject target;
	Vector2 moveDirection;
    GameObject healthBar;
	public Image health;
	void Start ()
	{
		
		rb = GetComponent<Rigidbody2D> ();
		target = GameObject.FindWithTag("Barrel");
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
		healthBar = GameObject.FindWithTag("HealthBar");
		health = healthBar.GetComponent<Image>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.gameObject.tag=="Barrel")
        {
			health.fillAmount -= 0.5f;
			if (health.fillAmount <= 0)
			{
				SceneManager.LoadScene("GameOver");
				Destroy(collision.gameObject);
				Destroy(this.gameObject);
			}


		}
	}

}
