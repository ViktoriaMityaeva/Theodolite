using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palka : MonoBehaviour
{
    public Gradus V;
    public Gradus2 G;
    public float PosUp;
    public float PosDown;
    public float PosUpT;
    public float PosDownT;
    public Image Up;
    public Image Down;
    public Text UpT;
    public Text DownT;

    void Update(){
        PosUp = (float)(V.y * 4.083333);
        PosUp = Mathf.Round(PosUp) + 602;
        PosUpT = PosUp + 55;
        Up.transform.position = new Vector3(PosUp, 790f, 0);
        UpT.transform.position = new Vector3(PosUpT, 790f, 0);     
       
        PosDown = (float)(G.y * 4.083333);
        PosDown = Mathf.Round(PosDown) + 602;
        PosDownT = PosDown + 55;
        Down.transform.position = new Vector3(PosDown, 740f, 0);
        DownT.transform.position = new Vector3(PosDownT, 660f, 0);
    }
}
