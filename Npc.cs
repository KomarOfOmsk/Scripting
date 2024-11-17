using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //�������� ���
    int health = 5;

    //������� ���
    int level = 1;

    //�������� ���
    float speed = 10.5f;

    //��������� �������
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        //�������� �������� ����������
        health = health + level;
        //������ ��������
        print("������: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        //���������� � ������� ������������ �������
        newPosition = transform.position;
        //��������� ��������� ������� �� ��� z
        newPosition.z += speed * Time.deltaTime;
        //������������ ������ ���������
        transform.position = newPosition;
    }
}
