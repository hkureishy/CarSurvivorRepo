using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FillStatusBar : MonoBehaviour
{
    public TMP_Text textHP;
    public trainAttributes trainHealth;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = trainHealth.health/ trainHealth.maxHealth;
        slider.value = fillValue;
        int HP = Mathf.FloorToInt(trainHealth.health);
        int HPMax = Mathf.FloorToInt(trainHealth.maxHealth);
         textHP.text = ("HP: "+ HP + " / " + HPMax);
    }
}
