using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BossEnemy : MonoBehaviour
{
    private GameObject player;
    private GameObject boss;
    public Transform firepoint;
    public GameObject bulletPrefab;
    public float bulletForce = 10f;
    float fireRate;
    float nextFire;
    private IEnumerator newShakeCoroutine;
    private Vector3 initialPosition;
    public bool coroutineAllowed;
    public AudioSource TankShakeAudio;
    public void Start()
    {
         fireRate = 5f;
         nextFire = Time.time;
        initialPosition = transform.position;
        coroutineAllowed = true;
    }
    void Update()
    {
        if (GameObject.FindWithTag("Barrel") != null)
        {
            player = GameObject.FindWithTag("Barrel");
            boss = GameObject.FindWithTag("Tank");
            Vector3 difference = boss.transform.position - player.transform.position;
            float rotationZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
            boss.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -rotationZ);
            Invoke("CheckIfTimeToFire", 4);
        }
    }

    void CheckIfTimeToFire()
    {
        if(Time.time>nextFire)
        {
            Instantiate(bulletPrefab, firepoint.transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

    public void StartShaking()
    {
        TankShakeAudio.Play();
        coroutineAllowed = false;
        newShakeCoroutine = ShakeCoroutine();
        StartCoroutine(newShakeCoroutine);
        Invoke("StopShaking", 0.5f);
    }
    private void StopShaking()
    {
        StopCoroutine(newShakeCoroutine);
        transform.position = initialPosition;
        coroutineAllowed = true;
    }
    private IEnumerator ShakeCoroutine()
    {
        coroutineAllowed = false;
        while (true)
        {
            float offsetX = Random.Range(-0.1f, 0.1f);
            float offsetY = Random.Range(-0.1f, 0.1f);
            transform.position = new Vector3(transform.position.x + offsetX, transform.position.y + offsetY, 0f);
            yield return new WaitForSeconds(0.01f);
            transform.position = initialPosition;
        }

    }
}
