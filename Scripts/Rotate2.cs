using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    public Rotate R;
    public Rotate L;
    public Ocular Lock;

    void Update()
    {
        if (Lock.locked != 1)
        {
            if (R.PressR)
                transform.Rotate(0, 0.4f * Time.deltaTime, 0);

            if (L.PressL)
                transform.Rotate(0, -0.4f * Time.deltaTime, 0);
        }
    }
}
