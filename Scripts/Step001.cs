using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step001 : MonoBehaviour
{
    public Camera_Trans1 Begin;
    public ButtonNext S;
    public GameObject p1;
    public GameObject p2;
    public bool PressRi = false; //��� ������ Main ������
    public bool PressLi = false; //��� ����� Main �����
    public bool Stop = true;
    public bool Step002 = false;
    private Outline outline;//��������� �������

    private void OnEnable()
    {
        outline = GetComponent<Outline>();
    }

    public void ButtonRClick(){
        PressRi = true;
    }

    public void ButtonLClick(){
        PressLi = true;
    }

    public void NotButtonClick(){
        PressRi = false;
        PressLi = false;
    }

    void Update(){
        if (S.S1)
            outline.OutlineWidth = 4;//������� ��������
        Vector3 P2 = p2.transform.position;
        Vector3 P3 = p2.transform.position - p1.transform.position;

        if (Begin.Step001)
        {
            if (PressLi && transform.rotation.x > -0.5) //�����������
            {
                transform.RotateAround(P2, P3, 50 * Time.deltaTime);
                Stop = false;
            }
            if(transform.rotation.x < -0.5)
            {
                Step002 = true;
                outline.OutlineWidth = 0;//���������
            }

            if (PressRi && transform.rotation.x < 0.3) //������������
            {
                transform.RotateAround(P2, P3, -50 * Time.deltaTime);
                Stop = false;
            }
        }
    }
}
