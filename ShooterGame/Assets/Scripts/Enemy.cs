using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Coin;
    private float _distance;
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _distance = Vector3.Distance(transform.position, Player.transform.position);    
        if(_distance >= 5f )
        {
            transform.position = Vector3.Lerp(transform.position, Player.transform.position, 1f * Time.deltaTime);
        }
        transform.LookAt(Player.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Instantiate(Coin, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
