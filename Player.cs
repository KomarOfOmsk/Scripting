using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    private int coins;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    // ћетод измен€ющий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("«доровье игрока: " + health);
    }

    public void CollectCoins()
    {
        coins++;
        print("—обранные монеты: " + coins);
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    
}
