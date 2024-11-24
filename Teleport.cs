using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //Меняет позицию игрока с позицией другого телепорта
        other.transform.position = teleportPoint.position;
    }
}
