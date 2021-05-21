using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Attributes
    [Header("Attributes")]
    [SerializeField] float spawnRate;
    [SerializeField] float spawnRateReduction;

    [SerializeField] int maxSpawn;
    int currentSpawn;
    float startTime;
    bool isSpawning = true;

    [Header("Component References")]
    [SerializeField] GameObject enemy;

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawning && currentSpawn < maxSpawn)
        {
            if(startTime + spawnRate + (Random.Range(-1.5f,1.5f)) < Time.time)
            {
                startTime = Time.time;
                currentSpawn++;
                spawnRate -= spawnRateReduction;
                Instantiate(enemy, transform.position, Quaternion.identity);
            }
        }
    }

    
}
