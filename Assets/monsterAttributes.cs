using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterAttributes : MonoBehaviour
{
[SerializeField] private trainAttributes train;
[SerializeField] private GameObject monster;
[SerializeField] private float speed = 1.5f;
[SerializeField] private float health;
[SerializeField] private float damage;
[SerializeField] private GameObject XP;
public string listenToTag = "Player";
public KeyCode listenToKey = KeyCode.F;

    void Start()
    {
        
    }
    void Update()
    {
         transform.position = Vector2.MoveTowards(transform.position, train.transform.position, speed * Time.deltaTime);
	
    }
	private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag(listenToTag))
        {
        train.takeDamage();
        Destroy(monster);
        }
        else
        {
        health = health-1;
	    if(health<=0) 
        {
            dropXP();
	        Destroy(monster);
     
        } 
       
        }
    }
    private void dropXP()
    {
        Instantiate(XP, transform.position ,Quaternion.identity);
    }
}