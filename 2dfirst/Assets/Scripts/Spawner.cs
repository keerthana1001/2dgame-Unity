using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject[] obstaclePatterns;
    private float timeBtwspawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
     
    private void Update()
    {
      if(timeBtwspawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwspawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {

                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwspawn -= Time.deltaTime;
        }
    }
}
