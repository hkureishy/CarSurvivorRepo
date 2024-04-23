using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class approach : MonoBehaviour
{
	[SerializeField] private GameObject train;
	[SerializeField] private float speed = 1.5f;
       
	void Start()
    {
        
    }

        void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, train.transform.position, speed * Time.deltaTime);
    }
}
