using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{

    public GameObject[] interfaces;

    public void ButtonEventFunction(string interfaceName)
    {
        for(int i = 0; i < interfaces.Length; i++)
        {
            
            if(interfaceName != interfaces[i].name)
                interfaces[i].SetActive(false);
            
            if(interfaceName == interfaces[i].name)
                interfaces[i].SetActive(true);
            
        }
    }

}
