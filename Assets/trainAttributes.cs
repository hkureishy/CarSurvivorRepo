using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainAttributes : MonoBehaviour
{
    [SerializeField] public float health;
    [SerializeField] private float damage;
    [SerializeField] private float shotSpeed;
    [SerializeField] private float pierce;
    [SerializeField] private float rateOfFire;
    [SerializeField] private float XP;
    [SerializeField] private float XPToNextLevel;
    [SerializeField] private trainAttributes train;
    public float power = 3;
    public float maxspeed = 5;
    public float turnpower = 2;
    public float friction = 3;
    public Vector2 curspeed ;
    Rigidbody2D rigidbody2D;


    void Start()
    {
         rigidbody2D = GetComponent<Rigidbody2D>();
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
        levelUp();
        die();
    }
   
     public void takeDamage()
    {
       health-=1;
    }
     public void getXP()
    {
       XP+=1;
    }
    public void getHP()
    {
       health+=1;
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
            XPToNextLevel = XPToNextLevel * 1.3f;
        }
    }
    public void die(){
         if(health<=0) 
        {
            
	       // Destroy(train);
         gameObject.GetComponent<Renderer>().enabled = false;
        } 
    }
    }
