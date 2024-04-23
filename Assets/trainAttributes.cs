using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainAttributes : MonoBehaviour
{
    [SerializeField] public float health;
    [SerializeField] private float damage;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float speed;
    [SerializeField] private float shotSpeed;
    [SerializeField] private float pierce;
    [SerializeField] private float rateOfFire;
    [SerializeField] private float XP;
    [SerializeField] private float XPToNextLevel;
    [SerializeField] private GameObject train;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(health<=0) 
        {
            
	       // Destroy(train);
         gameObject.GetComponent<Renderer>().enabled = false;
        } 
    }
   
     public void takeDamage()
    {
       health-=1;
    }
     public void getXP()
    {
       XP+=1;
    }
}
