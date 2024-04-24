using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
[SerializeField] private trainAttributes train;
[SerializeField] private GameObject rock;
[SerializeField] private float speed = 1.5f;
[SerializeField] private float health;
[SerializeField] private float damage;
[SerializeField] private GameObject XP;
[SerializeField] private GameObject HP;
public string listenToTag = "Player";
public KeyCode listenToKey = KeyCode.F;

    void Start()
    {
        
    }
    void Update()
    {
        
	
    }
	private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag(listenToTag))
        {
        train.takeDamage();
        Destroy(rock);
        }
        else
        {
        health = health-1;
	    if(health<=0) 
        {
            Drop();
	        Destroy(rock);
     
        } 
       
        }
    }
    private void Drop()
    { 
        int i = Random.Range(0, 10);
        if (i<8)
        {
        Instantiate(XP, transform.position ,Quaternion.identity);
        }
        else{
            Instantiate(HP, transform.position ,Quaternion.identity);
        }
    }
}