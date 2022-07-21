using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Barrel : MonoBehaviour
{
    public Transform barrelTip;
    public GameObject bullet;
    public GameObject crosshairs;
    public GameObject player;
    private Vector3 target;
    public Rigidbody2D rb;
    private float moveDir;
    public float moveSpeed;
    private Vector2 targetPos;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    
    void Update()
    {
        //player.transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f),transform.position.y,transform.position.z);
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -rotationZ);

        if (Input.GetMouseButtonUp(0))
        {
            Fire();
        }
        Movement();
    }

    private void Fire()
    {
        GameObject firedBullet1 = Instantiate(bullet, barrelTip.position, barrelTip.rotation);
        firedBullet1.GetComponent<Rigidbody2D>().velocity = barrelTip.up * 10f;
    }

    private void Movement()
    {
        moveDir = Input.GetAxis("Horizontal");
        //targetPos = new Vector2(Mathf.Clamp(transform.position.x + moveSpeed * moveDir * Time.deltaTime, -2f, 2f), Mathf.Clamp(transform.position.y, -1.7f, 1.7f));
        rb.velocity=new Vector2(moveDir*moveSpeed, rb.velocity.y);
    }
}
