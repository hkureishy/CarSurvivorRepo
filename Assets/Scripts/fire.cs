using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
	[SerializeField] private GameObject bullet;
	private Vector3 mousePos;
	[SerializeField] private Camera Cam1;
	private Rigidbody2D rb;
	[SerializeField] private float force=0;
	[SerializeField] private float damage;
	[SerializeField] private float pierce;
	[SerializeField] private float range;
	public string listenToTag = "Enemy";
	private GameObject train;
	[SerializeField] trainAttributes train2;
	[SerializeField] float timeShot;
       
	void Start()
    {
		train = GameObject.FindGameObjectWithTag("Player");
		Cam1 = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		mousePos = Cam1.ScreenToWorldPoint(Input.mousePosition);
		rb = GetComponent<Rigidbody2D>();
		Vector3 direction = mousePos - transform.position;
		rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
		Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), train.GetComponent<Collider2D>());
		timeShot = 0f;
		damage = train2.getDamage();
    }

        void Update()
    {  
		
		force = train2.getShotSpeed();
		range = train2.getRange();
		pierce = train2.getPierce();
		if (timeShot != -1)
		{
			timeShot += Time.deltaTime;
			if(timeShot>range)
			{
			   Destroy(bullet);
			}
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
    {
		if (other.CompareTag("Wall"))
		{
			timeShot = -1;
			force = 0;
		}
		if (other.CompareTag(listenToTag))
        {
			pierce -=1;
			if (pierce<=1) 
				{
					Destroy(bullet);
				} 
			}
		}
	}