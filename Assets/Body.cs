using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
   {
     public string listenToTag = "Player";
    [SerializeField] private trainAttributes train;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(listenToTag))
        {
        train.addMaxHealth();
        Destroy(this.gameObject);
        }
        
    }
}