using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainAttributes : MonoBehaviour
{
    [SerializeField] public float health;
     [SerializeField] public float maxHealth;
    [SerializeField] private float damage;
    [SerializeField] private float shotSpeed;
    [SerializeField] private float pierce;
    [SerializeField] private float rateOfFire;
    [SerializeField] private float XP;
    [SerializeField] private float XPToNextLevel;
    [SerializeField] private float range;
    [SerializeField] private trainAttributes train;
    public float power = 3;
    public float maxspeed = 5;
    public float turnpower = 2;
    public float friction = 3;
    public Vector2 curspeed ;
    Rigidbody2D rigidbody2D;
    [SerializeField] private float kills;
    [SerializeField] private float timeSurvived = 0f;
    public int level;
    public bool death;


    void Start()
    {
         rigidbody2D = GetComponent<Rigidbody2D>();
         rigidbody2D.freezeRotation = true;
         kills = 0;
         level = 0;
         death = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        curspeed = new Vector2(rigidbody2D.velocity.x,    rigidbody2D.velocity.y);

        if (curspeed.magnitude > maxspeed)
        {
            curspeed = curspeed.normalized;
            curspeed *= maxspeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddForce(transform.up * power);
             rigidbody2D.drag = friction;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.AddForce(-(transform.up) * (power/2));
            rigidbody2D.drag = friction;
        }
         if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * turnpower);
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.forward * -turnpower);
        }

        noGas();

    }
    void Update()
    {
        if (health>maxHealth)
        {
            health=maxHealth;
        }
        timeSurvived += Time.deltaTime;
        levelUp();
        die();
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{ 
   //     if (other.CompareTag("Fence"))
    //    {
    //       rigidbody2D.freeze r = true;
    //       transform.InverseTransformDirection(rigidbody2D.velocity);
    //    }
   // }
   // private void OnTriggerExit2D(Collider2D other)
   // { 
   //     if (other.CompareTag("Fence"))
   //     {
   //         rigidbody2D.isKinematic = false;
    //    }
   // }
   //
     public void takeDamage()
    {
       health-=1;
    }
     public void getXP()
    {
       XP+=1;
    }
    public float getPierce()
    {
        return pierce;
    }
    public void addPierce()
    {
        pierce+=1;
    }
     public float getShotSpeed()
    {
        return shotSpeed;
    }
      public void addShotSpeed()
    {
        shotSpeed+=2;
    }
     public void addPower()
    {
        power+=5;
        maxspeed+=1;
    }
    public float getDamage()
    {
        return damage;
    }
    public void addDamage()
    {
         damage +=5f;
    }
      public void addMaxHealth()
    {
        maxHealth+=10;
        health+=5;
    }
    public void addRange()
    {
        range+=1;
        

    }
    public void addROF()
    {
        rateOfFire-=.06f;
        
    }
    public float getRange()
    {
        return range;
    }
    public int getLevel()
    {
        return level;
    }
    public void getHP()
    {
       health+=1;
    }
    public void addKills()
    {
        kills+=1;
    }
    public float GetKills()
        {
            return kills;
        }
    public float GetTime()
        {
                    return timeSurvived;
        }
    public float GetROF()
        {
                    return rateOfFire;
        }
    public bool GetDeath()
    {
        return death;
    }
      void noGas()
    {
        bool gas;
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            gas = true;
        }
        else
        {
            gas = false;
        }

        if (!gas)
        {
            rigidbody2D.drag = friction * 2;
        }
    }
    public void levelUp(){
        if(XP>=XPToNextLevel)
        {
            XPToNextLevel = XPToNextLevel * 1.8f;
            level+=1;
        }
    }
    public void die(){
         if(health<=0) 
        {
            death = true;
	       // Destroy(train);
         gameObject.GetComponent<Renderer>().enabled = false;
        } 
    }
    }
