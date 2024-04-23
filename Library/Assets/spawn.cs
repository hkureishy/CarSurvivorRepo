using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour

{
    [SerializeField] private float spawnrate;
    [SerializeField] private GameObject enemy;
    void Start()
    {
         InvokeRepeating("Spawn", 1f, spawnrate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
	

	private void Spawn()
	{	
   	 Instantiate(enemy, transform.position, Quaternion.identity);
	}
}
