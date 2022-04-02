using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavDown : MonoBehaviour
{
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;

    public Rotate R;
    public Rotate L;
    public Ocular Lock;
    private Outline outline;//компонент обводки

    private void OnEnable()
    {
        outline = GetComponent<Outline>();
    }

    void Update()
    {
        if (Lock.locked != 1)
        {
            outline.OutlineWidth = 0;
            Vector3 P2 = p3.transform.position;
            Vector3 P3 = p3.transform.position - p4.transform.position;
            Vector3 P4 = p5.transform.position;
            Vector3 P5 = p5.transform.position - p6.transform.position;

            if (R.PressR)
            {
                transform.RotateAround(P2, P3, 21 * Time.deltaTime);
                transform.RotateAround(P4, P5, 0.4f * Time.deltaTime);
                outline.OutlineWidth = 4;//обводка включена
            }

            if (L.PressL)
            {
                transform.RotateAround(P2, P3, -21 * Time.deltaTime);
                transform.RotateAround(P4, P5, -0.4f * Time.deltaTime);
                outline.OutlineWidth = 4;//обводка включена
            }
        }
    }
}
