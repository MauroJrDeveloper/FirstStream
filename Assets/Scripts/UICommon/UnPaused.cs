using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnPaused : MonoBehaviour
{

    void Start()
    {
        if(Time.timeScale != 1)
            Time.timeScale = 1;
    }

}
