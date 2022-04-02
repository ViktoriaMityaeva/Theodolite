using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object001 : MonoBehaviour
{
    public bool PressR = false; //��� ������ Main ������
    public bool PressL = false; //��� ����� Main ������

    public Step001 stop;

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

    void Update(){
        if (PressR && stop.Stop)
        {
            transform.Rotate(0, 50 * Time.deltaTime, 0);

        }

        if (PressL && stop.Stop)
        {

            transform.Rotate(0, -50 * Time.deltaTime, 0);

        }
    }
}
