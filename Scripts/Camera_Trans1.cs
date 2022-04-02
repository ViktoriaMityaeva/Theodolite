using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Trans1 : MonoBehaviour
{
    public GameObject ButtonR_Main;
    public GameObject ButtonL_Main;
    public GameObject ButtonR_Middle;
    public GameObject ButtonL_Middle;
    public GameObject ButtonR_001;
    public GameObject ButtonL_001;
    public GameObject ButtonR_002;
    public GameObject ButtonL_002;
    public GameObject ButtonR_Up;
    public GameObject ButtonL_Up;

    public ObjectAll Cam;
    public bool Step001 = false;
    public bool Stop = true;
    public Step001 Begin;

    void Update(){
        if (Cam.NewCamera){
            if (transform.position.y > 0.8f && Stop)
                transform.position = transform.position + new Vector3(-0.002f, -0.001f, 0.003f);
            Quaternion target = Quaternion.Euler(20f, 40f, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
            Step001 = true;
            ButtonR_Middle.SetActive(true);
            ButtonL_Middle.SetActive(true);
            ButtonR_Main.SetActive(false);
            ButtonL_Main.SetActive(false);
            ButtonR_001.SetActive(true);
            ButtonL_001.SetActive(true);
            
        }

        if (Begin.Step002){
            Stop = false;
            if (transform.position.z < -0.55f)
                transform.position = transform.position + new Vector3(0f, 0.002f, 0.001f);
            ButtonR_Middle.SetActive(false);
            ButtonL_Middle.SetActive(false);
            ButtonR_001.SetActive(false);
            ButtonL_001.SetActive(false);
            ButtonR_Up.SetActive(true);
            ButtonL_Up.SetActive(true);
            ButtonR_002.SetActive(true);
            ButtonL_002.SetActive(true);
        }
    }
}
