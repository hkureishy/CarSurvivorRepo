using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private trainAttributes train;
    [SerializeField] private GameObject item1;
    [SerializeField] private GameObject item2;
    [SerializeField] private GameObject item3;
    [SerializeField] private GameObject item4;
    [SerializeField] private GameObject item5;
    [SerializeField] private GameObject item6;
    public int level;

    void Start()
    {
        level=0;
    }

    // Update is called once per frame
    void Update()
    {
       spawnItem();
    }
    public void spawnItem()
    {
         if (train.getLevel()>level)
        {   int itemPicker = Random.Range (0,5);
            switch (itemPicker)
            {
                case 0: 
                    Instantiate(item1, transform.position, Quaternion.identity);
                    break;
                case 1: 
                    Instantiate(item2, transform.position, Quaternion.identity);
                    break;
                case 2: 
                    Instantiate(item3, transform.position, Quaternion.identity);
                    break;
                case 3: 
                    Instantiate(item4, transform.position, Quaternion.identity);
                    break;
                case 4: 
                    Instantiate(item5, transform.position, Quaternion.identity);
                    break;
                case 5: 
                    Instantiate(item6, transform.position, Quaternion.identity);
                    break;
            }
            level+=1;
        }
    }
}
