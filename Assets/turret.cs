using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    private Vector3 mousePos;
	[SerializeField] private Camera Cam1;
    [SerializeField] private float shotSpeed;
    [SerializeField] private GameObject bullet;
    private float timeSinceLastShot=0;
    [SerializeField] private trainAttributes train;
    void Start()
    {
       shotSpeed = train.GetROF();
    }

    // Update is called once per frame
     void Update()
    {  
        timeSinceLastShot += Time.deltaTime;
	    mousePos = Cam1.ScreenToWorldPoint(Input.mousePosition);
	    Vector3 rotation = mousePos - transform.position;
	    float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg - 90;
	    transform.rotation = Quaternion.Euler(0,0, rotZ);
        if(timeSinceLastShot>shotSpeed)
        {
            SpawnBullet();
            timeSinceLastShot=0;
        }
    }
	

	private void SpawnBullet()
	{	
   	 Instantiate(bullet, transform.position, Quaternion.identity);
	}
}
