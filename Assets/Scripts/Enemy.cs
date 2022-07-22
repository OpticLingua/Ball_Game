using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 dirToTarget;
    public GameObject target;
    public float moveSpeed;
    private void Start()
    {
        target = GameObject.Find("Holder");
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveEnemy();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Score_Manager.Score += 1;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Barrel")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    void MoveEnemy()
    {
        dirToTarget = (target.transform.position - transform.position).normalized;
        rb.velocity = new Vector2(dirToTarget.x * moveSpeed, dirToTarget.y * moveSpeed);
    }


}
