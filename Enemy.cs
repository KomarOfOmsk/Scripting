using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    // Update is called once per frame
    void Update()
    {
        // ћен€ет позицию врага на новую каждый кадр
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        // –азворачивает врага к цели каждый кадр
        transform.LookAt(target.position);
    }
    
    // ѕри столкновении с игроком игроку наноситс€ урон
    public void onTriggerEnter (Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
    }
}
