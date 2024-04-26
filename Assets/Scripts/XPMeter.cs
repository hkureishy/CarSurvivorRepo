using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class XPMeter : MonoBehaviour
{
    public TMP_Text textXP;
    public trainAttributes trainXP;
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
        float fillValue = trainXP.XP/ trainXP.XPToNextLevel;
        slider.value = fillValue;
        int xp = Mathf.FloorToInt(trainXP.XP);
        int xpMax = Mathf.FloorToInt(trainXP.XPToNextLevel);
         textXP.text = ("XP: "+ xp + " / " + xpMax);
    }
}
