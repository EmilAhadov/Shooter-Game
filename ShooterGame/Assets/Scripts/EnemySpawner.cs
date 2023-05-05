using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    private void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        float x;
        float z;
        while (true)
        {
            x = Random.Range(-105f, 105f);
            z = Random.Range(-140f, 140f);
            transform.position = new Vector3(x, 1f, z);
            Instantiate(Enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
