using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    private void Start()
    {
        StartCoroutine(BulletSpawn());
    }

    IEnumerator BulletSpawn() 
    {
        while (true)
        {
            Instantiate(Bullet, transform.position + transform.forward *1f, transform.rotation);
            yield return new WaitForSeconds(3f);
        }
    }

}
