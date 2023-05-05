using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] float speed = 10;
    private Rigidbody _rb;
    [SerializeField] float force = 10;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed, Space.Self);
        Vector3 newPos = transform.position;
        newPos.x = Mathf.Clamp(newPos.x, -105f, 105f);
        newPos.z = Mathf.Clamp(newPos.z, -140f, 140f);

        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed, Space.Self);
        transform.position = newPos;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation *= Quaternion.Euler(0, -2f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation *= Quaternion.Euler(0f, 2f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftShift))  //&& Input.GetKey(KeyCode.W));
        {
            _rb.AddForce(new Vector3(300f,0f,0f));
            Debug.Log("DAsh");
        }
        
    }

}
