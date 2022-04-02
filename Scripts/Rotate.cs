using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool PressR = false; 
    public bool PressL = false;
    public Ocular Lock;

    public void ButtonRClick(){
        PressR = true;
    }

    public void ButtonLClick(){
        PressL = true;
    }

    public void NotButtonClick(){
        PressR = false;
        PressL = false;
    }

    void Update()
    {
        if (Lock.locked != 1)
        {
            if (PressR)
                transform.Rotate(0, 0.4f * Time.deltaTime, 0);

            if (PressL)
                transform.Rotate(0, -0.4f * Time.deltaTime, 0);
        }
    }
}
