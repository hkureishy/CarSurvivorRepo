using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private monsterAttributes enemy;
    private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("Enemy"))
        {
            enemy.setSpeed(0f);
        }
    }
}
