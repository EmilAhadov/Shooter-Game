using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    public Vector3 dicrease = new Vector3(0.02f, 0.75f, 0.75f);
    public Material Red;
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(CoinDestroy());
        }
    }
    private void Update()
    {
        transform.Rotate(0, 0.5f , 0);
    }
    IEnumerator CoinDestroy()
    {
        transform.localScale = new Vector3(transform.localScale.x-0.5f,transform.localScale.y-0.5f,transform.localScale.z);
        gameObject.GetComponent<Renderer>().material=Red;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
