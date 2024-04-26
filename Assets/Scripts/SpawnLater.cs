using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLater : MonoBehaviour

{
    [SerializeField] private float spawnrate;
    [SerializeField] private GameObject enemy;

    [SerializeField] private float nextSpawnTime = 0f;
    void Start()
    {
        InvokeRepeating("Spawn", 100f, spawnrate);

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
        Vector3 spawnDirection = Random.onUnitSphere;
        spawnDirection.y = 0; // Keep it at the ground level if required
        float spawnDistance = 10f; // How far from the spawner the enemy should appear

        Vector3 spawnPoint = transform.position + spawnDirection.normalized * spawnDistance;

        Instantiate(enemy, transform.position, Quaternion.identity);
    }

}
