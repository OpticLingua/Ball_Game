using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHolder : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
}
