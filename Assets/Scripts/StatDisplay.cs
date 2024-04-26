using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatDisplay : MonoBehaviour
{
    public TMP_Text stats;
    public trainAttributes trainHealth;
    void Update()
    {
        int HPMax = Mathf.FloorToInt(trainHealth.maxHealth);
        int damage = Mathf.FloorToInt(trainHealth.getDamage());
        int piercing = Mathf.FloorToInt(trainHealth.getPierce());
        int range = Mathf.FloorToInt(trainHealth.getRange());
        int shotSpeed = Mathf.FloorToInt(trainHealth.getShotSpeed());
        int speed = Mathf.FloorToInt(trainHealth.getPower());
        int rateOfFire = Mathf.FloorToInt(trainHealth.GetROF()*10f);
        int level = Mathf.FloorToInt(trainHealth.getLevel());
         stats.text = ("Stats:\r\n" + "\r\n" + "Level: "+level+"\r\n" + "\r\n" + "Max HP: "+ HPMax +"\r\n"+ "\r\n" + "Damage: " + damage +"\r\n"+ "\r\n"+"Speed: " + speed +"\r\n"+ "\r\n"+"Piercing: " + piercing+"\r\n" + "\r\n"+ "Range: " + range+"\r\n" + "\r\n"+ "Shot Speed: " + shotSpeed+"\r\n"+ "\r\n"+ "Rate of Fire: " + (10- rateOfFire));
    }
}
