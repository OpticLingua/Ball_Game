using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] monsters;
    int randomSpawnPoint, randomMonster;
    public static bool spawnAllowed;
    void Start()
    {
        InvokeRepeating("Spawner", 2f, 1f);
    }

   void Spawner()
    {
        randomSpawnPoint=Random.Range(0, spawnPoints.Length);
        randomMonster = Random.Range(0, monsters.Length);
        Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }
}
