using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Eye;
    [SerializeField] RaycastHit target;
    [SerializeField] float distance;
    public LayerMask layer;
    public Collider[] colliders;
    private Rigidbody _rb;
    private int bullet;
    [SerializeField] private GameObject _BOMB;
    private void Start()
    {
        bullet = 5;
        _rb= GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(bullet >= 0 && Physics.Raycast(transform.position, transform.forward, out target, 500,layer) )
            {
                    Instantiate(Bullet, transform.position + transform.forward * 1f, transform.rotation);
                    bullet -= 1;
                
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(_BOMB, transform.position + transform.forward * 1f, transform.rotation);
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(5f);
        bullet = 5;
    }
}
