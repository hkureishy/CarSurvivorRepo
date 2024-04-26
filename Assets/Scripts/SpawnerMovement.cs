using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    private float timeUntilSpawn;
    private float timer;
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float firstSpawnTime;
    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn-=Time.deltaTime;
        timer+=Time.deltaTime;
        if (timeUntilSpawn<=0 && firstSpawnTime<=timer)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }
    private void SetTimeUntilSpawn()
    {
        timeUntilSpawn = Random.Range(minTime, maxTime);
    }
}
