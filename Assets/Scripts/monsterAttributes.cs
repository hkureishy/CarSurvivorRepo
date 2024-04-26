using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterAttributes : MonoBehaviour
{
[SerializeField] private trainAttributes train;
[SerializeField] private approach approach;
[SerializeField] private GameObject monster;
[SerializeField] private float speed = 1.5f;
[SerializeField] private float health;
[SerializeField] private float damage;
[SerializeField] private GameObject XP;
[SerializeField] private GameObject HP;
public string listenToTag = "Player";
public KeyCode listenToKey = KeyCode.F;
[SerializeField] float timeAlive;

    void Start()
    {
        XP = GameObject.FindWithTag("XP");
        HP = GameObject.FindWithTag("HP");
        timeAlive = 0f;
    }
    void Update()
    {
        if (timeAlive != -1)
		{
			 transform.position = Vector2.MoveTowards(transform.position, train.transform.position, speed * Time.deltaTime);
		}
        else
        {
            this.approach.Stop();
        }
        
         
	
    }
	private void OnTriggerEnter2D(Collider2D other)
    {   if(other.CompareTag("Wall"))
        {
           timeAlive = -1f;
        }
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
                    Drop();
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
    private void Drop()
    { 
        int i = Random.Range(0, 20);
        if (i<18)
        {
        Instantiate(XP, transform.position ,Quaternion.identity);
        }
        else{
            Instantiate(HP, transform.position ,Quaternion.identity);
        }
    }
}