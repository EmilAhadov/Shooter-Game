using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] float distance;
    public LayerMask layer;
    public Collider[] colliders;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(transform.forward * 0.5f, ForceMode.Impulse);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            colliders = Physics.OverlapSphere(transform.position, distance, layer);
            StartCoroutine(Bomb1());
        }
    }
    IEnumerator Bomb1()
    {
        yield return new WaitForSeconds(2f);
        foreach (Collider collider in colliders)
        {
            collider.gameObject.AddComponent<Rigidbody>();
            Rigidbody rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.AddExplosionForce(250f, transform.position, distance * 2f);
            yield return new WaitForSeconds(2f);
            Destroy(rb.gameObject);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color32(128, 128, 128, 70);
        Gizmos.DrawSphere(transform.position, distance);
    }
}
