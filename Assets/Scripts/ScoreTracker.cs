using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public TMP_Text textScore;
    [SerializeField] private trainAttributes train;
    public float score;
    void Update()
    {
        score = train.GetKills() * train.GetTime();
         int scoreKeep = Mathf.FloorToInt(score);
         textScore.text = ("score: "+ scoreKeep);
    }
}
