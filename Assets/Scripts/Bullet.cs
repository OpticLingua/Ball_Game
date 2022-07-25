using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{

	float moveSpeed = 3f;
	Rigidbody2D rb;
	private GameObject target;
	Vector2 moveDirection;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		target = GameObject.FindWithTag("Barrel");
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);

	}
   
}
