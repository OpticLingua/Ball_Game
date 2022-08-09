using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] monsters;
    public GameObject[] powers;
    public GameObject boss;
    public GameObject player;
    int randomSpawnPoint, randomMonster, randomPowers;
    int flag = 0;
    int ctr = 0;
    void Start()
    {

        InvokeRepeating("Spawner", 0f, 1f);
        //InvokeRepeating("Spawner", 0f, 1f);
        Invoke("BossSpawner", 10f);
    }
   public void Spawner()
   {
        randomSpawnPoint=Random.Range(0, spawnPoints.Length);
        randomMonster = Random.Range(0, monsters.Length);
        Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        flag++;
        if(flag%13==0)
            PowerUPs();
   }
   public void BossSpawner()
   {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(boss, spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        ctr++;
        if (ctr % 3 == 0)
            PowerUPs();
   }
   public void PowerUPs()
   {
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        randomPowers = Random.Range(0, powers.Length);
        Instantiate(powers[randomPowers], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
   }

    
}
