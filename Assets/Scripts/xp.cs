using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xp : MonoBehaviour
{
    // Start is called before the first frame update
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
        train.getXP();
        Destroy(this.gameObject);
        }
        
    }
}
