using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        StartCoroutine(BulletDestroy());
    }
    private void Update()
    {
        _rb.AddForce(transform.forward * 3f, ForceMode.Impulse);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
    IEnumerator BulletDestroy()
    {
        yield return new WaitForSeconds(5f);
    }
}
