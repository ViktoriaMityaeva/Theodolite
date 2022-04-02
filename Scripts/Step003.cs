using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Step003 : MonoBehaviour
{
    public GameObject p7;
    public GameObject p8;
    public ButtonNext S;
    public bool End = true; 
    public bool PressR = false;
    public bool PressL = false;
    private Outline outline;//компонент обводки

    private void OnEnable()
    {
        outline = GetComponent<Outline>();
    }
    //кнопки ап
    public void ButtonRClick()
    {
        PressR = true;
    }

    public void ButtonLClick()
    {
        PressL = true;
    }

    public void NotButtonClick()
    {
        PressR = false;
        PressL = false;
    }

    void Update()
    {
        if (S.S2)
            outline.OutlineWidth = 4;//обводка включена
        else
            outline.OutlineWidth = 0;
        Vector3 P2 = p7.transform.position;
        Vector3 P3 = p7.transform.position - p8.transform.position;

        if (PressR)
        {
            End = false;
            transform.RotateAround(P2, P3, 50 * Time.deltaTime);
        }

        if (PressL && transform.position.x > -0.1) //закручивает
        {
            End = false;
            transform.RotateAround(P2, P3, -50 * Time.deltaTime);
        }
        if (PressL && transform.position.x < -0.05)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
