using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    [SerializeField] private trainAttributes train;
    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (train.GetDeath())
        {
            Cursor.visible = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

}