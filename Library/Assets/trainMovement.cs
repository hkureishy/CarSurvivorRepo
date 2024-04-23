using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainMovement : MonoBehaviour
{
	[SerializeField] float moveSpeed;
	float vertical, horizontal;
	Rigidbody2D myRigidbody2D;
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        moveTrain();
    }
	void moveTrain()
	{
		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");
		myRigidbody2D.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);

	}
}
