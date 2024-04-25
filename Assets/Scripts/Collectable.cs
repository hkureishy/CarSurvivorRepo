using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableType type;
    public Sprite icon;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerCollect player = collision.GetComponent<PlayerCollect>();

        if(player)
        {
            player.inventory.Add(this);
            Destroy(this.gameObject);
        }
    }
}

public enum CollectableType
{
    NONE, ENGINE, BATTERY, BODY, ROFBOOST, PIERCE, RANGE, SHOTSPEED, POWER
}