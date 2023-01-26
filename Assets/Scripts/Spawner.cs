using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject[] hazards;
    private float timeBtwSpawns;
    public float startTimeBtwSpawn;
    public float minTimeBtwSpawns;
    public float decrease;
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        if(Player!=null){
        if(timeBtwSpawns<=0)
        {
            Transform randomSpawnPoint =spawnPoints[Random.Range(0,spawnPoints.Length)];
            GameObject randomHazard=hazards[Random.Range(0,hazards.Length)];

            Instantiate(randomHazard,randomSpawnPoint.position,Quaternion.identity);
            if(startTimeBtwSpawn>minTimeBtwSpawns)
            {
                startTimeBtwSpawn-=decrease;
            }
            timeBtwSpawns=startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawns-=Time.deltaTime;

        }
        }
    }
}
