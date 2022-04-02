using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Main : MonoBehaviour
{
    public ObjectAll Close1;
    public ObjectAll Close2;
    public ObjectAll ButtonR;
    public ObjectAll ButtonL;
 
    public bool Camera = false;

    void Update(){
        if (Close1.Turn1 >= 10 || Close2.Turn2 >= 50){
            gameObject.SetActive(false);
            ButtonR.PressR = false;
            ButtonL.PressL = false;
            Camera = true;
        }
    }
}