using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{

    private bool isPaused;

    public KeyCode pauseKey;

    [HideInInspector]
    public GameObject pauseScreen;

    void Update()
    {
        if(Input.GetKeyDown(pauseKey))
            Pause();
    }

    void Pause()
    {
        if(!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
            pauseScreen.SetActive(true);
        }else
        {
            Time.timeScale = 1;
            isPaused = false; 
            pauseScreen.SetActive(false);
        }
    }

}
