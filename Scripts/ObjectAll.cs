using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAll : MonoBehaviour
{
    public bool PressR = false; //��� ������ Main ������
    public bool PressL = false; //��� ����� Main ������
    public int Turn1 = 0;       //�������� ��������
    public int Turn2 = 0;       //�������� ��������
    public bool NewCamera = false;

    public Button_Main NCamera;

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
        if (PressR){
            transform.Rotate(0, 50 * Time.deltaTime, 0);
            if ((transform.rotation.y >= 0.4) && (transform.rotation.y <= 0.8))
                Turn2++;
        }

        if (PressL){
            transform.Rotate(0, -50 * Time.deltaTime, 0);
            if ((transform.rotation.y <= -0.4) && (transform.rotation.y >= -0.65)) 
                Turn1++;
        }

        if (NCamera.Camera)
            NewCamera = true;
    }
}
