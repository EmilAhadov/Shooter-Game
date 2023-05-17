using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : MonoBehaviour
{
    private int health;
    private int money;

    private void Start()
    {
        health = 30;
        money = 0;
    }
    void Update()
    {

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            health -= 10;
            if (health == 0)
            {
                Destroy(gameObject);
            }
            Debug.Log($"Health: {health}");
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            money += 10;
            if (money == 30)
            {
                health += 10;
                money = 0;
                Debug.Log($"Money: {money}");
                Debug.Log($"Health: {health}");
            }
            else
            {
                Debug.Log($"Money: {money}");
            }
        }
    }
}
