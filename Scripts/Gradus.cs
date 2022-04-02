using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradus : MonoBehaviour
{
    public float x;
    public float y;
    public Text tt;

    void Update(){
        int GV = 180;
        x = ((transform.position.x * 10000000 - 2627927)/1516); //расчёт минут
        x = Mathf.Round(x);

        if (x < 0){
            GV = 181;
            tt.text = GV.ToString();
            x = x * (-1);
            while (x >= 60){
                x = x - 60;
                GV = GV + 1;
                tt.text = GV.ToString();
            }
            if (x < 60)
                y = x;
        }

        if (x >= 0){
            tt.text = GV.ToString();
            while (x >= 60){
                x = x - 60;
                GV = GV - 1;
                tt.text = GV.ToString();
            }
            if (x < 60)
                y = x;
        }
    }
}