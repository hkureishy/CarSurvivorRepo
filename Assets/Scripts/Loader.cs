using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loader : MonoBehaviour
{
    private bool switchScene;
    // Start is called before the first frame update
    void Start()
    {
        switchScene=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(switchScene == true)
        {
        SceneManager.LoadScene(0);
        switchScene=false;
        }

    }
    public void Switch(){
        switchScene= true;
    }
    public bool GetSwitch(){
        return switchScene;
    }
}
