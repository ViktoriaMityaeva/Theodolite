using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavUp : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    public Ocular Up;
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
            Vector3 P2 = p2.transform.position;
            Vector3 P3 = p2.transform.position - p1.transform.position;

            if (Up.clock == 1)
            {
                transform.RotateAround(P2, P3, 20 * Time.deltaTime);
                outline.OutlineWidth = 4;//обводка включена
            }

            if (Up.clock == -1)
            {
                transform.RotateAround(P2, P3, -20 * Time.deltaTime);
                outline.OutlineWidth = 4;//обводка включена
            }
        }
    }
}
