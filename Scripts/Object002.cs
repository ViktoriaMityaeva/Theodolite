using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object002 : MonoBehaviour
{
    public GameObject p5;
    public GameObject p6;

    public Step002 Star;
    public Step002 Star1;

    void Update()
    {
        Vector3 P2 = p5.transform.position;
        Vector3 P3 = p6.transform.position - p5.transform.position;
        
        if (Star.Start)
            transform.RotateAround(P2, P3, 20 * Time.deltaTime);  

        if (Star1.Start1)
            transform.RotateAround(P2, P3, -20 * Time.deltaTime);
    }
}