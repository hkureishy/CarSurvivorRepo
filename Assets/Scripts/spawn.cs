using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour

{
    [SerializeField] private float spawnrate;
    [SerializeField] private GameObject enemy;

    [SerializeField] private float nextSpawnTime = 0f;
    void Start()
    {
        InvokeRepeating("Spawn", 1f, spawnrate);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + 1f / spawnrate;
        }

    }


    private void Spawn()
    {
        var randomDirection = new Vector2(Random.Range(1f,360f), Random.Range(1f,360f)); 
        float spawnDistance = 10f; // How far from the spawner the enemy should appear
        Vector2 transform2D = transform.position;

        Vector2 spawnPoint = transform2D + randomDirection * spawnDistance;

        Instantiate(enemy, transform.position, Quaternion.identity);
    }

}
