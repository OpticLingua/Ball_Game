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
   
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
    void Update()
    {
        if (UIPages.IsPaused == false)
        {
            target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
            crosshairs.transform.position = new Vector2(target.x, target.y);

            Vector3 difference = target - player.transform.position;
            float rotationZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
            player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -rotationZ);

            if (Input.GetMouseButtonDown(0))
            {
                Fire();
            }
            Movement();
        }
    }
    public void Fire()
    {
        GameObject firedBullet1 = Instantiate(bullet, barrelTip.position, barrelTip.rotation);
        firedBullet1.GetComponent<Rigidbody2D>().velocity = barrelTip.up * 10f;
    }
    private void Movement()
    {
        moveDir = Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(moveDir*moveSpeed, rb.velocity.y);
    }
}
