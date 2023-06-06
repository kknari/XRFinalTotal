using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public X x;
    public GameObject r;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("x");
            X temp = GameObject.Instantiate(x, r.transform.position, transform.rotation);
            temp.dir = r.transform.position - transform.position;
            temp.fire();
        }
    }
}
