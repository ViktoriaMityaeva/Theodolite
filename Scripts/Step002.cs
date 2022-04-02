using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step002 : MonoBehaviour
{
    public GameObject p3;
    public GameObject p4;

    //—крипт дл€ окул€ра 
    public bool PressR = false; 
    public bool PressL = false;
    public Step001 Begin;
    public Step003 En;
    public bool Start = false;
    public bool Start1 = false;
    //кнопки мидл 2
    public void ButtonRClick()
    {
        PressR = true;
    }

    public void ButtonLClick()
    {
        PressL = true;
    }

    public void NotButtonClick()
    {
        PressR = false;
        PressL = false;
    }

    void Update()
    {
        if (Begin.Step002)
        {
            Start = false;
            Start1 = false;
            Vector3 P2 = p4.transform.position;
            Vector3 P3 = p4.transform.position - p3.transform.position;

            if (PressR && En.End)
            {
                Start = true;
                transform.RotateAround(P2, P3, 20 * Time.deltaTime);
            }

            if (PressL && En.End)
            {
                Start1 = true;
                transform.RotateAround(P2, P3, -20 * Time.deltaTime);
            }
        }
    }
}