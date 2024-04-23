using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    private Vector3 mousePos;
	[SerializeField] private Camera Cam1;
    [SerializeField] private float shotSpeed;
    [SerializeField] private GameObject bullet;
    void Start()
    {
         InvokeRepeating("SpawnBullet", 1f, shotSpeed);
    }

    // Update is called once per frame
     void Update()
    {  
	mousePos = Cam1.ScreenToWorldPoint(Input.mousePosition);
	Vector3 rotation = mousePos - transform.position;
	float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg - 90;
	transform.rotation = Quaternion.Euler(0,0, rotZ);
    }
	

	private void SpawnBullet()
	{	
   	 Instantiate(bullet, transform.position, Quaternion.identity);
	}
}
