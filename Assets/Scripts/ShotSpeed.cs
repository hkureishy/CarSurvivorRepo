using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpeed : MonoBehaviour
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
        train.addShotSpeed();
        Destroy(this.gameObject);
        }
        
    }
}
