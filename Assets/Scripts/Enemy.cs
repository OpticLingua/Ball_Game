using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public static int flag=1;
    Rigidbody2D rb;
    Vector3 dirToTarget;
    public GameObject target;
    public float moveSpeed;

    public EnemySpawner spawn;
    private void Start()
    {
        target = GameObject.Find("Holder");
        rb = GetComponent<Rigidbody2D>();
        spawn=ScriptableObject.FindObjectOfType<EnemySpawner>();
    }

    private void Update()
    {
        MoveEnemy();
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Score_Manager.Score += 1;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            flag += 1;
            if (flag % 10 == 0)
                spawn.BossSpawner();
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
