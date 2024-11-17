using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //здоровье нпс
    int health = 5;

    //уровень нпс
    int level = 1;

    //скорость нпс
    float speed = 10.5f;

    //положение объекта
    Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        //сложение значений переменных
        health = health + level;
        //Печать значений
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        //переменная с данными расположения объекта
        newPosition = transform.position;
        //Изменение положения объекта по оси z
        newPosition.z += speed * Time.deltaTime;
        //Присваивание нового положения
        transform.position = newPosition;
    }
}
