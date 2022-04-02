using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNext2 : MonoBehaviour
{
    public GameObject ButtonR; public GameObject ButtonL;
    public GameObject Button1; public GameObject Button2;
    public GameObject Button3; public GameObject Button4;
    public GameObject Button5; public GameObject Button6;
    public GameObject Button7; public GameObject Button8;
    public GameObject Button_Next; public GameObject Button_Next3; public GameObject Button_Next4;
    public bool S1 = false;
    public int click = 0;
    public CameraOcular loc;
    public Image Im; public Image Im3;
    public Text t1; public Text t5; public Text t6; public Text t7;

    public void ButtonClick(){
        click++;
    }

    public void ButtonClickExit(){
        click = 100;
    }

    void Start(){
        ButtonR.SetActive(false); ButtonL.SetActive(false);
        Button1.SetActive(false); Button2.SetActive(false);
        Button3.SetActive(false); Button4.SetActive(false);
        Button5.SetActive(false); Button6.SetActive(false);
        Button7.SetActive(false); Button8.SetActive(false);
        Button_Next3.SetActive(false); Button_Next4.SetActive(false);
        t5.enabled = false;
        t6.enabled = false;
        t7.enabled = false;
        Im3.enabled = false;
    }

    void Update(){
        if (click == 1){
            t1.enabled = false;
            Im.enabled = false;
            Button_Next.SetActive(false);
            Button_Next3.SetActive(true);
            t5.enabled = true;
            Im3.enabled = true;
            Button6.SetActive(true);
            Button7.SetActive(true);
            Button8.SetActive(true);
            S1 = true;
        }

        if (click == 2){
            S1 = false;
            Button1.SetActive(true);
            Button2.SetActive(true);
            Button3.SetActive(true);
            Button4.SetActive(true);
            Button5.SetActive(true);
            t5.enabled = false;
            t6.enabled = true;
        }

        if (click == 3){
            t6.enabled = false;
            Im3.enabled = false;
            Button_Next3.SetActive(false);
            ButtonR.SetActive(true);
            ButtonL.SetActive(true);
        }

        if (loc.locked == 1){
            t6.enabled = false;
            Im3.enabled = false;
            Button_Next3.SetActive(false);
            Button_Next4.SetActive(true);
            ButtonR.SetActive(true);
            ButtonL.SetActive(true);
            Im3.enabled = true;
            t7.enabled = true;
        }

        if (click == 100){
            Button_Next4.SetActive(false);
            Im3.enabled = false;
            t7.enabled = false;
        }
    }
}