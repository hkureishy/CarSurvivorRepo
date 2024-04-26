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
        setSpeed(3f);
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
            dropXP();
        }
        else
        {
            if (other.CompareTag("Bullet"))
            {
                health = health - train.getDamage();
	            if(health<=0) 

                {
                    dropXP();
                    train.addKills();
	                Destroy(monster);
     
                } 
            }
       
        }
    }
    private void dropXP()
    {
        Instantiate(XP, transform.position ,Quaternion.identity);
    }
    public void setSpeed(float f){
        speed = f;
    }
}