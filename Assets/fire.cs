using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
	[SerializeField] private GameObject bullet;
	private Vector3 mousePos;
	[SerializeField] private Camera Cam1;
	private Rigidbody2D rb;
	[SerializeField] private float force;
	[SerializeField] private float pierce;
	[SerializeField] private float range;
	public string listenToTag = "Enemy";
       
	void Start()
    {
		Cam1 = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		mousePos = Cam1.ScreenToWorldPoint(Input.mousePosition);
		rb = GetComponent<Rigidbody2D>();
		Vector3 direction = mousePos - transform.position;
		rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

        void Update()
    {  
	
    }
	private void OnTriggerEnter2D(Collider2D other)
    {
		if (other.CompareTag(listenToTag))
        {
      pierce = pierce-1;
	if(pierce<=1) 
        {
	  Destroy(bullet);
        } 
		}
	}
}
