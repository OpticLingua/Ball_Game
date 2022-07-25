using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    private GameObject player;
    private GameObject boss;
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 10f;
    float fireRate;
    float nextFire;
    public void Start()
    {
        
         fireRate = 5f;
         nextFire = Time.time;
    }
    void Update()
    {
        player = GameObject.FindWithTag("Barrel");
        boss = GameObject.FindWithTag("Tank");
        Vector3 difference = boss.transform.position - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
        boss.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -rotationZ);       
        Invoke("CheckIfTimeToFire",4);
    }

    void CheckIfTimeToFire()
    {
        if(Time.time>nextFire)
        {
            Instantiate(bulletPrefab, firepoint.transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
