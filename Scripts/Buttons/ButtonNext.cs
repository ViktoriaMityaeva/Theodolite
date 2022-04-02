using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNext : MonoBehaviour
{
    public GameObject ButtonR_Main; public GameObject ButtonL_Main;
    public GameObject ButtonR_001; public GameObject ButtonL_001;
    public GameObject Button_Next; public GameObject Button_Next2; public GameObject Button_Next3;
    public bool S1 = false; public bool S2 = false;
    public int click = 0;
    public Image Im; public Image Im2; public Image Im3;
    public Text t1; public Text t2; public Text t3;
    public Text t4; public Text t5; public Text t6;

    public void ButtonClick(){
        click++;
    }

    void Start(){
        ButtonR_Main.SetActive(false);
        ButtonL_Main.SetActive(false);
        ButtonR_001.SetActive(false);
        ButtonL_001.SetActive(false);
        Button_Next2.SetActive(false);
        Button_Next3.SetActive(false);
        t2.enabled = false;
        t3.enabled = false;
        t4.enabled = false;
        t5.enabled = false;
        t6.enabled = false;
        Im2.enabled = false;
        Im3.enabled = false;
    }

    void Update(){
        //S1 = false;
        if (click == 1){
            t1.enabled = false;
            t2.enabled = true;
        }

        if (click == 2){
            t2.enabled = false;
            Im.enabled = false;
            Button_Next.SetActive(false);
            ButtonR_Main.SetActive(true);
            ButtonL_Main.SetActive(true);
            S1 = true;
            Button_Next2.SetActive(true);
            t3.enabled = true;
            Im2.enabled = true;
        }

        if (click == 3){
            t3.enabled = false;
            t4.enabled = true;
        }

        if (click == 4){
            Button_Next2.SetActive(false);
            Button_Next3.SetActive(true);
            t4.enabled = false;
            t5.enabled = true;
            Im2.enabled = false;
            Im3.enabled = true;
            S2 = true;
        }

        if (click == 5){
            t5.enabled = false;
            t6.enabled = true;
        }
    }
}