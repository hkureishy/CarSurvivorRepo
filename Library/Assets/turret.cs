using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    [SerializeField] private float shotSpeed;
    [SerializeField] private GameObject bullet;
    void Start()
    {
         InvokeRepeating("SpawnBullet", 1f, shotSpeed);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
	

	private void SpawnBullet()
	{	
   	 Instantiate(bullet, transform.position, Quaternion.identity);
	}
}
