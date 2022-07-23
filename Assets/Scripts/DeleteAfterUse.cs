using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterUse : MonoBehaviour
{
    public GameObject player;
    public GameObject boss;
    void Update()
    {
        Vector3 difference = boss.transform.position - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.x, difference.y) * Mathf.Rad2Deg;
        boss.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -rotationZ);
    }
}
